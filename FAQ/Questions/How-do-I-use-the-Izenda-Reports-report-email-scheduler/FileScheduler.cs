using Izenda.AdHoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

public class FileScheduler
{
    public static void RunScheduledReports(TextWriter log, DateTime dateTime)
    {
        if (AdHocSettings.ResponseServer == "rs.aspx")
        {
            string url = HttpContext.Current.Request.Url.ToString();
            int index = url.LastIndexOfAny(new char[] { '/', '\\' });
            if (index > 0)
            {
                string path = url.Substring(0, index);
                if (!path.EndsWith("/") && !path.EndsWith("\\"))
                    path += "/";
                AdHocSettings.ResponseServer = string.Format("{0}{1}", path, "rs.aspx");
            }
        }

        string[] tenants = ListTenants();
        RunSchedulerForTenant(log, dateTime, null);
        foreach (string tenant in tenants)
            RunSchedulerForTenant(log, dateTime, tenant);
    }

    protected static void RunSchedulerForTenant(TextWriter log, DateTime dateTime, string tenantId)
    {
        AdHocSettings.CurrentUserIsAdmin = true;
        AdHocSettings.CurrentUserTenantId = tenantId;
        try
        {
            string delimiter = HttpContext.Current == null ? Environment.NewLine : "<br/>";
            bool reportsFound = false;

            ReportInfo[] reports = AdHocSettings.AdHocConfig.ListReports();
            foreach (ReportInfo reportInfo in reports)
            {
                if (string.IsNullOrEmpty(reportInfo.Name))
                    continue;
                ReportSet reportSet = null;
                try
                {
                    reportSet = AdHocSettings.AdHocConfig.LoadFilteredReportSet(reportInfo.FullName);
                }
                catch { }
                if (reportSet == null)
                    continue;
            
                DateTime schedule = reportSet.Schedule;
                string reportName = reportInfo.Name;
                if (!string.IsNullOrEmpty(reportInfo.Category))
                    reportName = reportInfo.Category + "\\" + reportInfo.Name;
                reportSet.ReportName = reportName;
                reportsFound = true;
                if (schedule == Utility.NullDateTime || string.IsNullOrEmpty(reportSet.Recipients))
                {
                    log.Write(string.Format("{1}{0} - No Schedule{1}", reportName, delimiter));
                    continue;
                }
                if (schedule.Year == DateTime.MaxValue.Year)
                {
                    log.Write(string.Format("{1}{0} - Scheduled For Past {1}", reportName, delimiter));
                    continue;
                }
                if (schedule > dateTime)
                {
                    log.Write(string.Format("{1}{0} - Scheduled In Future({2} @ {3}){1}", reportName, delimiter, schedule.ToShortDateString(), schedule.ToShortTimeString()));
                    continue;
                }
                try
                {
                    log.Write(string.Format("{1}{0} - Scheduled For This Interval ({2} @ {3}){1}", reportName, delimiter,  schedule.ToShortDateString(), schedule.ToShortTimeString()));
                    string[] recipients = reportSet.Recipients.Split(',', ';');

                    byte[] content = null;
                    if (recipients.Length > 0)
                    {
                        log.Write("Preparing content - ");
                        content = GetOutput(reportSet);
                        DateTime nextSchedule = Utility.GetNextTime(schedule, reportSet.RepeatType).DateTime;
                        while (nextSchedule < DateTime.Now)
                            nextSchedule = Utility.GetNextTime(nextSchedule, reportSet.RepeatType).DateTime;
                        reportSet.Schedule = nextSchedule;
                        AdHocSettings.AdHocConfig.SaveReportSet(reportInfo, reportSet);
                        log.Write(string.Format("success{0}", delimiter));
                    }

                    log.Write(string.Format("Saving To:{0}", delimiter));
                    foreach (string recipient in recipients)
                        try
                        {
                            log.Write(string.Format("{0} - ", recipient));
                            SaveOutputToFile(content, recipient, reportSet);
                            log.Write(string.Format("success{0}", delimiter));
                        }
                        catch (Exception ex)
                        {
                            StringBuilder emessage = new StringBuilder();
                            while (ex != null)
                            {
                                emessage.Append(ex.Message + " ");
                                ex = ex.InnerException;
                            }
                            log.Write(string.Format("failure ({0}){1}", emessage, delimiter));
                        }
                    log.Write("Done. {0}", delimiter);
                }
                catch (Exception ex)
                {
                    StringBuilder emessage = new StringBuilder();
                    while (ex != null)
                    {
                        emessage.Append(ex.Message + " ");
                        ex = ex.InnerException;
                    }
                    log.Write(string.Format("failure ({0}){1}", emessage, delimiter));
                }
            }
            if (!reportsFound)
                log.Write(string.Format("Reports Not Found {0}", delimiter));
        }
        catch { }
    }

    protected static string[] ListTenants()
    {
        if (string.IsNullOrEmpty(HttpContext.Current.Request.Params["tenants"]))
            return new string[] { };
        return HttpContext.Current.Request.Params["tenants"].Split(',');
    }

    private static byte[] GetOutput(ReportSet rs)
    {
        byte[] res = null;
        ReportOutputGenerator outGenerator = null;
        switch (rs.SendEmailAs)
        {
            case "PDF":
                outGenerator = new ITextSharpPdfGenerator();
                break;
            case "HTML2PDF":
                outGenerator = new Html2PdfGenerator();
                break;
            case "CSV":
                outGenerator = new CsvReportOuputGenerator();
                break;
            case "XLS(MIME)":
                outGenerator = new HtmlOutputGenerator("xls");
                break;
            case "Word(RTF)":
                outGenerator = new HtmlOutputGenerator("rtf");
                break;
            case "HTML":
                outGenerator = new HtmlOutputGenerator("html");
                break;
        }
        res = outGenerator.GenerateOutput(rs).Content;
        return res;
    }

    private static void SaveOutputToFile(byte[] output, string folder, ReportSet rs)
    {
        string extension = "";
        switch (rs.SendEmailAs)
        {
            case "PDF":
                extension = "pdf";
                break;
            case "HTML2PDF":
                extension = "pdf";
                break;
            case "CSV":
                extension = "csv";
                break;
            case "XLS(MIME)":
                extension = "xls";
                break;
            case "Word(RTF)":
                extension = "rtf";
                break;
            case "HTML":
                extension = "html";
                break;
        }

        string fileName = Path.Combine(folder, rs.ReportName) + "." + extension;
        if (!Directory.Exists(Path.Combine(folder, rs.ReportCategory)))
            Directory.CreateDirectory(Path.Combine(folder, rs.ReportCategory));
        using (FileStream file = File.Create(fileName))
        {
            file.Write(output, 0, output.Length);
        }
    }
}