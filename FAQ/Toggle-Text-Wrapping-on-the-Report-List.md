#Toggle Text Wrapping on the Report List

##Instructions

On the report list, you can toggle the wrapping for the report titles. To accomplish this, modify the css/main.css file. Find the string "**word-break:**" under the "#tabs .thumbs div.thumb-title" CSS rule and replace the word that follows with either "**break-all**" to text wrap or "**normal**" to disable text wrapping.

```csharp
#tabs .thumbs div.thumb-title {
  color: #000; 
  display: block;
  font-family: "Droid Sans", Tahoma, "Segoe UI", sans-serif !important;
  font-size: 14.5px;
  letter-spacing: 0px;
  line-height: 20px;
  padding: 2px 0 0 6px;
  position: relative; 
  word-break: normal; //Setting to change
}
```