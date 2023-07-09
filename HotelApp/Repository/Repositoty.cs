using HotelApp.Models;
using System.Data.SqlClient;

namespace HotelApp.Repository
{
	public class Repository : IRepository
	{
		public readonly IConfiguration _configuration;
		public Repository(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public List<Property> GetHotels()
		{
			string connectString = _configuration.GetConnectionString("Default");
			using (SqlConnection connection = new(connectString))
			{
				string query = "SELECT * FROM PictureDb";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						List<Property> hotels = new List<Property>();

						while (reader.Read())
						{

							string hotelImageUrl = reader.GetString(reader.GetOrdinal("hotelImageUrl"));
							string hotelName = reader.GetString(reader.GetOrdinal("hotelName"));
							string hotelLocation = reader.GetString(reader.GetOrdinal("hotelLocation"));
							string hotelPrice = reader.GetString(reader.GetOrdinal("hotelPrice"));
							string hotelGroup = reader.GetString(reader.GetOrdinal("hotelGroup"));
							string hotelDescription = reader.GetString(reader.GetOrdinal("hotelDescription"));
							string hotelPopularity = reader.GetString(reader.GetOrdinal("hotelPopularity"));
							string isPopular = reader.GetString(reader.GetOrdinal("isPopular"));

							var hotel = new Property(hotelImageUrl, hotelName, hotelLocation, hotelPrice, hotelDescription, hotelGroup, hotelPopularity, isPopular);

							hotels.Add(hotel);
						}

						return hotels;
					}
				}
			}
		}
	}
}
