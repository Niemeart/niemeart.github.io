﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Remove("Username");
        FormsAuthentication.SignOut();
        // Response.Redirect(Request.UrlReferrer.ToString());
        Response.Redirect("Logout.aspx");
    }
}