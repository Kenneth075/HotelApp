using HotelApp.Models;
using HotelApp.RegUsersRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace HotelApp.Controllers
{
	public class RegUsersTblController : Controller
	{

		private readonly IRegUsersRepository _regUsersRepository;
		private readonly IServiceProvider _serviceProvider;
		public RegUsersTblController(IRegUsersRepository regUsersRepository, IServiceProvider serviceProvider)
		{
			_regUsersRepository = regUsersRepository;
			_serviceProvider = serviceProvider;
		}
		
		public IActionResult LoginPage()
		{
			return View();
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
	

		[HttpPost]
		public IActionResult SignUp(RegUsersTbl User)
		{
			try
			{
				using (var context = new HotelAppContext(_serviceProvider.GetRequiredService<DbContextOptions<HotelAppContext>>()))
				{
					context.Set<RegUsersTbl>().Add(User);
					context.SaveChanges();
				}
				return RedirectToAction("Loginpage");
			}
			catch (Exception ex)
			{

			}

			return View();
		}



	}
}