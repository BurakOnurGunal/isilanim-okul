using Entities;
using System;
using System.Collections;
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
	public partial class Register : System.Web.UI.Page
	{
		DataAccessLayer.isilanimDbEntities dbEntities = new DataAccessLayer.isilanimDbEntities();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void RegisterPageLoginButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}

		protected void RegisterButton_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Adays Adays = new DataAccessLayer.Adays();
			Adays.IdentityNumber = IdentityNumber.Value;
			Adays.FirstName = FirstName.Value;
			Adays.LastName = LastName.Value;
			Adays.BirthYear = Convert.ToInt32(BirthYear.Value);
			Adays.Email = Email.Value;
			Adays.Password = Convert.ToInt32(Password.Value);
			Adays.Authority = "Aday";


			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44321/");

				var result = client.PostAsync("api/Aday/add", new StringContent(
					new JavaScriptSerializer().Serialize(Adays), Encoding.UTF8, "application/json")).Result;

				if (result.StatusCode == System.Net.HttpStatusCode.OK)
				{
					Label1.Text = "Aday eklendi.";
				}
				else
					Label1.Text = "Aday Eklenemedi.";

			}

		}

		protected void RegisterCalisanButton_Click(object sender, EventArgs e)
		{
			DataAccessLayer.Calisans Calisans = new DataAccessLayer.Calisans();


			Calisan Calisan = new Calisan();

			Calisan.CompanyName = "yok";
			Label1.Text= Calisan.CalisanAdd(Calisan,Calisans,dbEntities);


		}

	}
}