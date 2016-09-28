#Custom Aggregate Functions

[[_TOC_]]

##Question

Can I define my own grouping and aggregate functions in Izenda? If so, how?

##Answer

Yes, you can use as many custom aggregate functions as you like. Within the AdHocSettings class exists a collection called [[AggregateFunctions|http://wiki.izenda.us/API/CodeSamples/AggregateFunctions]] that can be used to implement your own custom aggregate functions. For a detailed description of this item, click the above link. We will demonstrate other techniques of adding a custom function to this list below.

###Method 1: SimpleAggregateFunction

The SimpleAggregateFunction class in the AdHoc namespace has multiple overloads that allow for various implicitly named aggregate functions. The parameters are as follows:

* **Overload 1**:
  * **Function** - This is the name of the aggregate function to use. This can get applied to a SELECTed field or to a field in the GROUP BY clause. The corresponding database function must only take a single parameter to operate correctly.
* **Overload 2**:
  * **Function** - As above.
  * **Caption** - This is the text that will appear in the function dropdown menu on the [[Fields tab|http://wiki.izenda.us/Guides/ReportDesign/4.0-fields-tab]].
* **Overload 3**:
  * **Function** - As above.
  * **Caption** - As above.
  * **isGroup** - A boolean value specifying whether this is a grouping function. 
  * **isExtraFunction** - A boolean value specifying whether this is 
* **Overload 4**:
  * **Function** - As above.
  * **Caption** - As above.
  * **allowedTypeGroups** - A list of SqlTypeGroups that use the associated enumeration to determine for which data types this function is valid.
  * **isGroup** - As above.
  * **isExtraFunction** - As above.
* **Overload 5**:
  * **Function** - As above.
  * **Caption** - As above.
  * **allowedTypeGroups** - A list of SqlTypeGroups that use the associated enumeration to determine for which data types this function is valid.
  * **disallowedTypeGroups** - A list of SqlTypeGroups that use the associated enumeration to determine for which data types this function is not valid. If allowedTypeGroups is used (not null), this setting has no effect.
  * **isGroup** - As above.
  * **isExtraFunction** - As above.

And below is what the resulting function could look like.

```csharp
    AdHocSettings.AggregateFunctions["Group By Absolute Value"] = new SimpleAggregateFunction("ABS", "Group (Absolute Value)", new SqlTypeGroup[] { SqlTypeGroup.Numeric, SqlTypeGroup.Real }, true, true);
```

###Method 2: New class

You may introduce your own custom class to contain your aggregate function. A custom class is useful for when you are using more complex expressions that require specific conditional formatting of the parameters. This class simply inherits the IAggregateFunction interface, overriding each of the interface's methods. See the example below for what this could look like.

```csharp
public class GroupByFiscalYearFunction : IAggregateFunction {
    public string GetSQL(string innerExpression, SqlType type) {
      //returns the portion of the GROUP BY clause just after the GROUP BY keyword and wraps around the respective field selected in the fields dropdown list.
      return string.Format("DATEPART(yyyy, DATEADD(mm, 3, {0}))", innerExpression);
    }

    private string caption;
    public string Caption { get { return caption; } }

    private Hashtable allowedTypeGroups = null;
    public Hashtable AllowedTypeGroups {
      get { return allowedTypeGroups; }
    }

    private Hashtable disallowedTypeGroups = null;
    public Hashtable DisallowedTypeGroups {
      get { return disallowedTypeGroups; }
    }

    private bool _isScalar;
    public bool IsScalar {
      get {
        return _isScalar;
      }
      set {
        _isScalar = value;
      }
    }

    private bool isGroup;
    public bool IsGroup {
      get { return isGroup; }
    }

    public bool CompatibilityWithFunction(bool isExtraFunction) {
      return true;
    }

    private SqlType outputType = SqlType.Unknown;
    public SqlType OutputType {
      get { return outputType; }
      set { outputType = value; }
    }

    private bool isExtraFunction = false;
    public bool IsExtraFunction {
      get { return isExtraFunction; }
    }

    public IFormatter[] Formatters {
      get { return new IFormatter[0]; }
    }

    public GroupByFiscalYearFunction() {
      this.caption = "Group (Fiscal Year)";

      this.allowedTypeGroups = new Hashtable(2);
      this.allowedTypeGroups.Add(SqlTypeGroup.DateTime, true);
      this.allowedTypeGroups.Add(SqlTypeGroup.Date, true);

      this.isGroup = true;
    }
  }
```