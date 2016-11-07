#Logging Basics
[[_TOC_]]

##Enabling Logging

Izenda utilizes Log4Net as the default logging provider. This logging ability is included with every implementation of Izenda since version 6.7.1.265. By default, the logging level is set to FATAL, so almost nothing is logged. To change this, and "enable" logging, just change the error level in the log4net.xml file to something less restrictive. In the next section, the specifics of how to make this change will be shown. 

##Disabling Logging

To disable logging, add this setting in your Global:

AdHocContext.DisableLogging = true;

Add it before any other call, for example before the connection string, in the initialization or start event.

##Basic Configuration

In log4net.xml:

```xml
<log4net>    
  <appender name="rollingFile" type="log4net.Appender.RollingFileAppender,log4net">        
    <file value="" />			  
    <param name="AppendToFile" value="true"/>			  
    <param name="RollingStyle" value="Date"/>			  
    <param name="DatePattern" value="MM-dd-yyyy'-FATAL.log'"/>			  
    <param name="StaticLogFileName" value="false"/>        
    <layout type="log4net.Layout.PatternLayout">            
      <conversionPattern value="%date [%thread] %-5level %logger [%property{NDC}] - %message%newline" />        
    </layout>    
  </appender>    
  <root>        
    <level value="FATAL" />        
    <appender-ref ref="rollingFile" />    
  </root>
</log4net>
```

###Logging level

There are three default levels of logging: Info, Error, and Fatal

####Info

```xml
  <level value="Info" /> 
```

Info logs all events. It will rapidly generate a large log. We recommend Info only when chasing an obscure bug, or to diagnose Izenda's internal workflow.

####Error

```xml
  <level value="Error" /> 
```

Error logs non-fatal erroneous behavior. It is useful when looking for undesired or abnormal behavior within Izenda.

####Fatal
```xml
  <level value="FATAL" /> 
```

Fatal only logs severe errors that cause crashes or program termination. Very few items are logged at this level.

###File name

```xml
<param name="DatePattern" value="MM-dd-yyyy'-FATAL.log'"/>
```
The value here ends up being the name of the log file output. It is recommended you change the "-FATAL" part if you change your logging level. The output file will be placed in the root level of the application. 

## Logging Specific Sections

It is possible to log the behavior of certain areas, and ignore others. For example, if we wanted to get only the current settings variables:

AdHocContext.LogActiveAreas = new List<LogArea>() { LogArea.Settings };

Or, if you want to diagnose the Dash 2.0 page, then a configuration like this would be useful:

AdHocContext.LogActiveAreas = new List<LogArea>() { LogArea.WebService, LogArea.ResponseServer };

##More Information

For more information about logging, please visit the [log4net documentation](http://logging.apache.org/log4net/release/features.html).