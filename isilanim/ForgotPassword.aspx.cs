using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isilanim
{
	public partial class ForgotPassword : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ResetPassword_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Adays Adays = new DataAccessLayer.Adays();
			DataAccessLayer.isilanimDbEntities dbEntities = new DataAccessLayer.isilanimDbEntities();

			var person = dbEntities.Adays.FirstOrDefault(
				x => x.Email == Email.Value );

			if (person != null)
			{
				
				Adays.Password =Convert.ToInt32(Password.Value);
				dbEntities.Entry(Adays).State = EntityState.Modified;
				dbEntities.SaveChanges();
				
			}
			else
			{
				Label1.Text = "Böyle bir mail yok";
			}

		}

	}
}