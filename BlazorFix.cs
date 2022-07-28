using Microsoft.AspNetCore.Builder;

namespace _3ai.solutions.BlazorSubdirectoryFix
{
    public static class BlazorFix
    {
        public static IApplicationBuilder UseBlazorFix(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.HasValue && context.Request.Path.Value.Contains("_content") && !context.Request.Path.Value.StartsWith("/_"))
                {
                    string url = context.Request.Path.Value;
                    url = url[url.IndexOf("_")..];
                    context.Response.Redirect($"/{url}");
                }
                else
                    await next.Invoke();
            });
            return app;
        }
    }
}