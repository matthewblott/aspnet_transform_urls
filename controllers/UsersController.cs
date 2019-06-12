using Microsoft.AspNetCore.Mvc;
using aspnet_transform_urls.models;

namespace aspnet_transform_urls.controllers
{
  public class UsersController : Controller
  {
    public IActionResult Index()
    {
      var userViewModel = new UserViewModel();
      
      return View(userViewModel);
    }

    [HttpPost]
    public IActionResult Create()
    {
      return RedirectToAction(nameof(Index));

    }
    
    public IActionResult Find(string firstName, string lastName)
    {
      var user = new UserViewModel
      {
        FirstName = firstName,
        LastName = lastName
      };
      
      return View(nameof(Index), user);

    }
    
  }
  
}