using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isilanim
{
	public partial class Login : System.Web.UI.Page
	{
		DataAccessLayer.isilanimDbEntities dbEntities = new DataAccessLayer.isilanimDbEntities();
		
		protected void Page_Load()
		{
			
		}

	
		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Register.aspx");
		}

		protected void ForgotPassword_Click(object sender, EventArgs e)
		{
			Response.Redirect("ForgotPassword.aspx");
		}
		
		protected void btnCalisan_Click(object sender, EventArgs e)
		{
			var user = dbEntities.Calisans.FirstOrDefault(
				x => x.CompanyMailAddress == emailCalisan.Value && x.Password.ToString() == passowordCalisan.Value);

			if (user == null)
			{
				labelError.Text = "hatalı şifre veya mail";
			}
			else
			{
				Session.Add("name", user.CompanyName);
				Response.Redirect("CalisanPage.aspx");
			}
		}

		protected void btnAday_Click1(object sender, EventArgs e)
		{

			Aday Aday = new Aday();
			using (var client =new HttpClient())
			{
				client.BaseAddress=new Uri("https://localhost:44321/");

				var result = client.PostAsync("api/Aday",new StringContent(
					new JavaScriptSerializer().Serialize(Aday),Encoding.UTF8,"application/json")).Result;
			}

		}
	}
}