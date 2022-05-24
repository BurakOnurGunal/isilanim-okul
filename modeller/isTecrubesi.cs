using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class isTecrubesi
	{
		[Key]
		public int Id { get; set; }
		public string WorkPlaceName { get; set; }
		public string Position { get; set; }
		public DateTime StartYear { get; set; }
		public DateTime EndYear { get; set; }
		public int CvId { get; set; }
		public Cv Cv { get; set; }

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
