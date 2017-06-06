#ProcessFriendlyException

[[_TOC_]]

##About

Represents a method that produces more user-friendly output when a report has errors. This will be rendered to the web browser.

##C# Example

```csharp
public override Control ProcessFriendlyException(Exception exception)
{
	return new LiteralControl("exception occurred "  + exception.Message);
}
```

##VB.NET Example

```visualbasic
Public Overrides Function ProcessFriendlyException(exception As Exception) As Control
        Return New LiteralControl("exception occurred " + exception.Message)
End Function
```