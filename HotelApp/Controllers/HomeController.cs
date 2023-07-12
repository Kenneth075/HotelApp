 using HotelApp.Models;
using HotelApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPictureDbRepository _repository;
		public HomeController(IPictureDbRepository repository)
		{
		   _repository = repository;
		}
		
		public IActionResult Index()
		{
			List<PictureDb> Properties = _repository.GetHotels();
			var mostpicks = Properties.Where(p => p.HotelPopularity == "Most Picks").ToList();
			var first_mostpick = mostpicks.FirstOrDefault();
			var beautybackyard = Properties.Where(p => p.HotelDescription == "beauty backyard").ToList();
			var livingroom = Properties.Where(p => p.HotelDescription == "living room").ToList();
			var apartment = Properties.Where(p => p.HotelDescription == "Apartment").ToList();
			ViewData["mostpicks"] = mostpicks;
			ViewData["first_mostpicks"] = first_mostpick;
			ViewData["beautybackyard"] = beautybackyard;
			ViewData["livingroom"] = livingroom;
			ViewData["apartment"] = apartment;

			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

