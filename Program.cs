using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
class Program
{
    static void Main()
    {
        CreateWebHostBuilder().Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder() =>
        WebHost.CreateDefaultBuilder()
            .UseStartup<Startup>();
}

class Startup
{
      public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
