# 3ai.solutions.BlazorSubdirectoryFix

We had an issue with Blazorise where blazor was injecting the component js files adding the subdirectory infront of the path for the file
i.e. subdirectory_content/etc.js this is a hacky way to redirect to the correct file.

```c#
app.UseBlazorFix();
```
