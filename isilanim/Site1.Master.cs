﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace isilanim
{
	public partial class Site1 : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (Session["name"] == null)
			{
				UserNameSession.Text = "Giriş Yap";
				Session["Authority"]="User";
				LoginUsername.Visible = true;
			}
			else
			{
				UserNameSession.Text = Session["name"].ToString();
				LoginUsername.Visible = false;
			}
		}
	}
}