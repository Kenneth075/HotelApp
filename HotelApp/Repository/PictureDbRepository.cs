using HotelApp.Models;

namespace HotelApp.Repository
{
	public class PictureDbRepository : IPictureDbRepository
	{
		private readonly HotelAppContext _picturecontext;

        public PictureDbRepository(HotelAppContext picturecontext)
        {
            _picturecontext = picturecontext;
        }
        public List<PictureDb> GetHotels()
        {
            return _picturecontext.PictureDbs.ToList();
        }

    }
}
