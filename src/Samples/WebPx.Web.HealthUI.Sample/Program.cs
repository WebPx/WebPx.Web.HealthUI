using WebPx.Web.HealthUI.Sample.HealthChecks;

namespace WebPx.Web.HealthUI.Sample
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddHealthChecks()
                .AddCheck<HealthCheck>("Sample");

            // Add the Health UI
            // The following code setups the Health UI with the default settings
            builder.Services.AddHealthUI(c =>
            {
                c.BaseUri = "/";
                c.BootstrapPath = "/lib/bootstrap";
                c.BootstrapIconPath = "/lib/bootstrap-icons";
            }, builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
