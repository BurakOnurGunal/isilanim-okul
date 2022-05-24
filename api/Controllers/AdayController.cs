using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiProject.Controllers
{
	public class AdayController : ApiController
    {
		Aday AdayAdd = new Aday();

		// api/Aday
		[HttpGet]
		public IHttpActionResult GetAllAday()
		{
			//List<Adays> list = db.Adays.ToList();
			var list = AdayAdd.GetAllAday();
			return Ok(list);
		}

		// api/Aday/add

		[HttpPost]
		public IHttpActionResult Add([FromBody] Aday Aday)
		{
			var result=AdayAdd.Add(Aday);
			if (result)
			{
				return Ok(HttpStatusCode.OK);
			}
			return Ok(HttpStatusCode.BadRequest);
		}

		// api/Aday/id
		[HttpGet]
		public IHttpActionResult GetById(int id)
		{
			var result = AdayAdd.GetById(id);
			return Ok(result);
		}
    }
}
