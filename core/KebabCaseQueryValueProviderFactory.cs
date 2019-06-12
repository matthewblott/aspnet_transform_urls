using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace aspnet_transform_urls.core
{
  public class KebabCaseQueryValueProviderFactory : IValueProviderFactory
  {
    public Task CreateValueProviderAsync(ValueProviderFactoryContext context)
    {
      if (context == null)
      {
        throw new ArgumentNullException(nameof(context));
      }

      var valueProvider = new KebabCaseQueryValueProvider(
        BindingSource.Query,
        context.ActionContext.HttpContext.Request.Query,
        CultureInfo.CurrentCulture);

      context.ValueProviders.Add(valueProvider);

      return Task.CompletedTask;
    }
    
  }
  
}