using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    
   public class Login : Controller
   {
       public IActionResult LoginPage()
       {
          return View();
       }
   }
    
}
