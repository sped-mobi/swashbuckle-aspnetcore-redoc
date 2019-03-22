using System;
using Swashbuckle.AspNetCore.ReDoc;

namespace Microsoft.AspNetCore.Builder
{
    public static class ExtendedRedocBuilderExtensions
    {
        public static void SetReDocDocumentTitle(this ReDocOptions options, string documentTitle)
        {
            options.DocumentTitle = documentTitle;
        }
        public static void SetReDocSpecUrl(this ReDocOptions options, string specUrl)
        {
            options.SpecUrl = specUrl;
        }

        public static void SetReDocRoutePrefix(this ReDocOptions options, string routePrefix)
        {
            options.RoutePrefix = routePrefix;
        }

        public static IApplicationBuilder UseReDocEx(this IApplicationBuilder app, string title, string url, string prefix)
        {
            return app.UseReDoc(c =>
            {
                c.SetReDocDocumentTitle(title);
                c.SetReDocSpecUrl(url);
                c.SetReDocRoutePrefix(prefix);
            });
        }


        public static IApplicationBuilder SetReDocDocumentTitle(this IApplicationBuilder app, string documentTitle)
        {
            app.UseReDoc(c =>
            {
                c.DocumentTitle = documentTitle;
            });

            return app;
        }


        public static IApplicationBuilder SetReDocSpecUrl(this IApplicationBuilder app, string specUrl)
        {
            app.UseReDoc(c =>
            {   
                c.SpecUrl = specUrl;
            });

            

            return app;
        }

        public static IApplicationBuilder SetReDocRoutePrefix(this IApplicationBuilder app, string routePrefix)
        {
            app.UseReDoc(c =>
            {
                c.RoutePrefix = routePrefix;
            });



            return app;
        }
    }
}
