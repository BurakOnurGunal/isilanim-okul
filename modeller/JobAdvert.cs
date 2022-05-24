using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class JobAdvert
	{
		[Key]
		public int Id { get; set; }
		public string JobDescription { get; set; }
		public string JobTitle { get; set; }
		public string CityName { get; set; }
		public string OpenPosition { get; set; }
		public bool IsActive { get; set; }

		public int CalisanId { get; set; }
		public Calisan Calisan { get; set; }
		public List<JobAdvert> GetAllJobAdverts()
		{
			using (DataAccessLayer.isilanimDbEntities db=new DataAccessLayer.isilanimDbEntities())
			{
				var result = (from j in db.JobAdverts
							  select new JobAdvert
							  {
								  CityName=j.CityName,
								  OpenPosition=j.OpenPosition,
								  JobTitle=j.JobTitle,
								  JobDescription=j.JobDescription,
								  Id=j.Id,
								  IsActive=j.IsActive,
								  CalisanId=j.CalisanId
							  }).ToList();
				return result;
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
}
