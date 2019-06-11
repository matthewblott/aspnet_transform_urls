using Microsoft.AspNetCore.Mvc;

namespace aspnet_transform_urls.controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("[controller]/[action]")]
    public string HelloWorld() => "Hello World!";

    public string Customer([FromRoute(Name = "customer-id")]int customerId) => $"The Customer Id is {customerId}";

  }
    
}
