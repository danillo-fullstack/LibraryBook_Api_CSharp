using System.Globalization;

namespace LibraryBook.Api.Middleware;

public class CultureMiddleware(RequestDelegate next)
{
    private static readonly CultureInfo[] SupportedCultures =
        CultureInfo.GetCultures(CultureTypes.AllCultures);

    public async Task Invoke(HttpContext context)
    {
        var culture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        var cultureInfo = new CultureInfo("en");

        var isSupportedLanguage = SupportedCultures
            .Any(language =>
                language.Name.Equals(culture, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(culture) && isSupportedLanguage)
        {
            cultureInfo = new CultureInfo(culture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await next(context);
    }
}