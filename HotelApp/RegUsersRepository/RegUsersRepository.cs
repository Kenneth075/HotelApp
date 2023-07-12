using HotelApp.Models;

namespace HotelApp.RegUsersRepository
{
	public class RegUsersRepository : IRegUsersRepository
	{
		private readonly HotelAppContext _appContext;

		public RegUsersRepository(HotelAppContext appContext)
		{
			_appContext = appContext;
		}

		public List<RegUsersTbl> GetRegUsers()
		{
			return _appContext.RegUsersTbls.ToList();

		}
	}
}
