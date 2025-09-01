namespace ProductCatalog.MudBlazors.Extension
{
    public static class WebApplicationExtensions
    {
        /// <summary>
        /// Configures middleware, error pages, routing, and Blazor endpoints.
        /// </summary>
        public static WebApplication UseAppPipeline(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            return app;
        }
    }
}
