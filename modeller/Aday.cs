using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Aday
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string IdentityNumber { get; set; }
		public int BirthYear { get; set; }
		public string Email { get; set; }
		public int Password { get; set; }
		public int CvId { get; set; }
		public List<Cv> Cv { get; set; }
		public string Authority { get; set; }
		
		public string AdayAdd(List<Aday> Adays, DataAccessLayer.Adays Aday)
		{
			foreach (var item in Adays)
			{
				Aday.FirstName = item.FirstName;
				Aday.LastName = item.FirstName;
				Aday.Password = item.Password;
				Aday.IdentityNumber = item.IdentityNumber;
				Aday.BirthYear = item.BirthYear;
				Aday.Email = item.Email;
				Aday.Authority = item.Authority;
			}

			DataAccessLayer.isilanimDbEntities dal = new DataAccessLayer.isilanimDbEntities();
			dal.Adays.Add(Aday);
			dal.SaveChanges();

			return "Listeye Aday Eklendi";
		}

		public bool Add(Aday Aday)
		{
			bool added=false;
			using (DataAccessLayer.isilanimDbEntities db = new DataAccessLayer.isilanimDbEntities())
			{
				db.Adays.Add(new DataAccessLayer.Adays()
				{
					FirstName = Aday.FirstName,
					LastName = Aday.LastName,
					Password = Aday.Password,
					IdentityNumber = Aday.IdentityNumber,
					BirthYear = Aday.BirthYear,
					Email = Aday.Email,
					Authority = "Aday"
				});
				var response = db.SaveChanges();
				if (response==1)
				{
					added = true;
				}
			}
			
			return added; // 1 or 0 
		}

		public List<Aday> GetAllAday()
		{
			using (DataAccessLayer.isilanimDbEntities db=new DataAccessLayer.isilanimDbEntities())
			{
				var result = (from c in db.Adays.ToList()
							  select new Aday
							  {
								  FirstName = c.FirstName,
								  LastName=c.LastName
							  }).ToList();
				return result;
			}
		}
		public List<Aday> GetById(int id)
		{
			using (DataAccessLayer.isilanimDbEntities db=new DataAccessLayer.isilanimDbEntities())
			{

				var result = from c in db.Adays.Where(c => c.Id == id)
							 select new Aday
							 {
								 FirstName=c.FirstName,
								 LastName=c.LastName,
								 Email=c.Email,
								 BirthYear=c.BirthYear,
							 };

				return result.ToList();
			}
		}
	}
}
