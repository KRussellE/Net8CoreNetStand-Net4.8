using Microsoft.AspNetCore.Http;

public static class HttpRequestExtensions
{
    public static string GetRawUrl(this HttpRequest request)
    {
        var httpContext = request.HttpContext;
        return $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString}";
    }
}
