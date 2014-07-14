#Logging Basics
[[_TOC_]]

##Enabling Logging

Izenda utilizes Log4Net as the default logging provider. This logging ability is included with every implementation of Izenda since version 6.7.1.265. By default, the logging level is set to FATAL, so almost nothing is logged. To change this, and "enable" logging, just change the error level to something less restrictive. In the next section, the specifics of how to make this change will be shown. 

##Basic Configuration
```xml
<root>
  <level value="FATAL" />
  <appender-ref ref="rollingFile" />
</root>
```
The level value change be changed to any of the following; FATAL, ERROR, WARN, INFO, DEBUG and ALL. These are listed in ascending order of logged output. Set this level appropriately to catch the information you need from the logging. 

```xml
<param name="DatePattern" value="MM-dd-yyyy'-FATAL.log'"/>
```
The value here ends up being the name of the log file output. It is recommended you change the "-FATAL" part if you change your logging level. The output file will be placed in the root level of the application. 

##More Information

For more information about logging, please visit the [log4net documentation](http://logging.apache.org/log4net/release/features.html). There is significantly more information there than anyone will ever need. 