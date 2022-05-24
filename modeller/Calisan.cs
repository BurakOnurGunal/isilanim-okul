using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Calisan
	{
		[Key]
		public int CalisansId { get; set; }
		public string Name { get; set; }
		public int Phone { get; set; }
		public string CompanyMailAddress { get; set; }
		public string CompanyName { get; set; }
		public string Password { get; set; }

		public List<JobAdvert> JobAdverts { get; set; }

		public string CalisanAdd
			(Calisan CalisansList, DataAccessLayer.Calisans Calisan,DataAccessLayer.isilanimDbEntities db)
		{

			Calisan.CompanyName= CalisansList.CompanyName;

			db.Calisans.Add(Calisan);
			db.SaveChanges();

			return "Calisan Eklendi.";
		}


		public string getir(string id, DataAccessLayer.isilanimDbEntities db)
		{
            if (null == null)
            {
				return "bulunamadı" ;
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
