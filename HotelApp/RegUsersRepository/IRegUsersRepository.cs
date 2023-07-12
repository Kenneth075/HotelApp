using HotelApp.Models;

namespace HotelApp.RegUsersRepository
{
	public interface IRegUsersRepository
	{
		List<RegUsersTbl> GetRegUsers();
	}
}
