using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
	public class CustomerDetails
	{
		public CustomerDetails()
		{
			RegDate = DateTime.Now;
		}

		[Required]
		public int Id { get; set; }

		[Required]
		public string? FirstName { get; set;}

		[Required]
		public string? LastName { get; set; }
		[Required]
		public string? Email { get; set; }

		[Required]
		public string? Password { get; set; }

		[Required]
		public DateTime RegDate { get; set; }

		public CustomerDetails(int id, string firstname, string lastname, string email, string password, DateTime regDate)
		{
			Id = id;
			FirstName = firstname;
			LastName = lastname;
			Email = email;
			Password = password;
			RegDate = regDate;
		}

	}
}
