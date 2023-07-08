using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace HotelApp.Controllers
{
	public class CustomerDetailsController : Controller
	{

		private readonly IConfiguration _configuration;
		public CustomerDetailsController(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		//
		public IActionResult LoginPage()
		{
			return View();
		}

		//
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignUp(CustomerDetails User)
		{
			if (ModelState.IsValid)
			{
				string connectString = _configuration.GetConnectionString("Default");
				using (SqlConnection con = new SqlConnection(connectString))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "INSERT INTO User_Table(FirstName, LastName, Email, Password, DateTime) " +
									  "VALUES (@FirstName, @LastName, @Email, @Password, @DateTime)";
					cmd.Connection = con;

					// Add parameters to the command
					//cmd.Parameters.AddWithValue("@Id", User.Id);
					cmd.Parameters.AddWithValue("@FirstName", User.FirstName);
					cmd.Parameters.AddWithValue("@LastName", User.LastName);
					cmd.Parameters.AddWithValue("@Email", User.Email);
					cmd.Parameters.AddWithValue("@Password", User.Password);
					cmd.Parameters.AddWithValue("@DateTime", User.RegDate);

					con.Open();
					cmd.ExecuteNonQuery();
				}
				Console.WriteLine("Success reached");
				return RedirectToAction("LoginPage");
			}

			return View();
		}



	}
}