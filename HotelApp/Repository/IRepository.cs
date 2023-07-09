using HotelApp.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace HotelApp.Repository
{
	public interface IRepository
	{
		List<Property> GetHotels();

	}
}
