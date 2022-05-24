using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isilanim
{
	public partial class JobAdverts : System.Web.UI.Page
	{
		protected async void Page_Load(object sender, EventArgs e)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress=new Uri("https://localhost:44321/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(
					new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/Aday/getallAday");
				if (response.IsSuccessStatusCode)
				{
					string data = await response.Content.ReadAsStringAsync();
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					AdayGridView.DataSource = javaScriptSerializer.Deserialize<List<Aday>>(data);
					AdayGridView.DataBind();				
				}
				else
				{
					Console.WriteLine("Internal server Error");
				}
			}
		}
	}
}