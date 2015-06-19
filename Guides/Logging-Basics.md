#Logging Basics
[[_TOC_]]

##Enabling Logging

Izenda utilizes Log4Net as the default logging provider. This logging ability is included with every implementation of Izenda since version 6.7.1.265. By default, the logging level is set to FATAL, so almost nothing is logged. To change this, and "enable" logging, just change the error level in the log4net.xml file to something less restrictive. In the next section, the specifics of how to make this change will be shown. 

##Basic Configuration
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

```xml
  <level value="FATAL" /> 
```

The level value change be changed to any of the following; FATAL, INFO, and ALL. These are listed in ascending order of amount of logged output. Set this level appropriately to catch the information you need from the logging. 

###File name

```xml
<param name="DatePattern" value="MM-dd-yyyy'-FATAL.log'"/>
```
The value here ends up being the name of the log file output. It is recommended you change the "-FATAL" part if you change your logging level. The output file will be placed in the root level of the application. 

##More Information

For more information about logging, please visit the [log4net documentation](http://logging.apache.org/log4net/release/features.html). There is significantly more information there than anyone will ever need. 