using System.Globalization;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace aspnet_transform_urls.core
{
  public class KebabCaseQueryValueProvider : QueryStringValueProvider, IValueProvider
  {
    public KebabCaseQueryValueProvider(
      BindingSource bindingSource, 
      IQueryCollection values, 
      CultureInfo culture) 
      : base(bindingSource, values, culture)
    {
    }

    public override bool ContainsPrefix(string prefix)
    {
      var kebabCase = prefix.Kebaberize();
      var value =  base.ContainsPrefix(kebabCase);
      
      return value;
      
    }

    public override ValueProviderResult GetValue(string key)
    {
      var kebabCase = key.Kebaberize();
      
      var value = base.GetValue(kebabCase);
      
      return value;

    }
    
  }

}