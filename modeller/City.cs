using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class City
	{
		[Key]
		public int CityId { get; set; }
		public string CityName { get; set; }

		public List<JobAdvert> JobAdvert { get; set; }

		public List<City> GetAllCity()
		{
			using (DataAccessLayer.isilanimDbEntities db = new DataAccessLayer.isilanimDbEntities())
			{
				var result = from c in db.Cities.ToList()
							 select new City
							 {
								 CityName = c.CityName,

							 };
							  
				return result.ToList();
			}
		}
		public string getir(string id, DataAccessLayer.isilanimDbEntities db)
		{
			if (null == null)
			{
				return "bulunamadı";
			}
			return "bulundu";
		}

		public string Delete(string id = null, DataAccessLayer.Calisans Calisan, DataAccessLayer.isilanimDbEntities db)
		{
			Calisan Calisans = db.Calisans.Find(id -);
			if (Calisans == null)
			{
				return "bulunamadı";
			}
			return "bulundu";
		}

	}
}
