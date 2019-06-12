using aspnet_transform_urls.core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace aspnet_transform_urls
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc(options =>
      {
//        options.Conventions.Add(new RouteTokenTransformerConvention(
//          new SlugifyParameterTransformer()));
//        
//        options.ValueProviderFactories.Add(new KebabCaseQueryValueProviderFactory());

      });
     
      services.AddRouting(option =>
      {
        option.ConstraintMap["slugify"] = typeof(SlugifyParameterTransformer);
        option.LowercaseUrls = true;
      });
      
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseStaticFiles();
      app.UseRouting();
      app.UseCors();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute("default", "{controller:slugify}/{action:slugify}/{id?}", 
          defaults: new { controller = "Home", action = "Index" });
      });      

    }
    
  }
  
}
