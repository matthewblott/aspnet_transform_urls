using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace aspnet_transform_urls.core
{
  public class SlugifyParameterTransformer : IOutboundParameterTransformer
  {
//    public string TransformOutbound(object value) => value == null ? null : 
//      Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower();
    
    // Slugify value
    public string TransformOutbound(object value) => value == null ? null : 
      Regex.Replace(value.ToString(),"([a-z])([A-Z])", "$1-$2", RegexOptions.None, 
        TimeSpan.FromMilliseconds(100)).ToLower();
    
  }
  
  
  
}