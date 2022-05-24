using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Cv
	{
		[Key]
		public int id { get; set; }
		public string GitHubLink { get; set; }		
		public string CoverLetter { get; set; }
		public bool Active { get; set; }
		public Aday Aday { get; set; }
		public List<isTecrubesi> JobExperience { get; set; }
		public List<School> Schools { get; set; }

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
