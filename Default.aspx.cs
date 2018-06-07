using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class _Default : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.IsInRole("Admin"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Archive/AArchive.aspx");
        }
        if (Page.User.IsInRole("ABS"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20ABS/AABS.aspx");
        }
        if (Page.User.IsInRole("Teamviewer"))
        {
            Response.Redirect("~/Download/Teamviewer/Teamviewer.aspx");
        }
        if (Page.User.IsInRole("TeamviewerUser"))
        {
            Response.Redirect("~/Download/Teamviewer/Teamviewer.aspx");
        }
        if (Page.User.IsInRole("Arkisto"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Archive/AArchive.aspx");
        }
        if (Page.User.IsInRole("AS"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20AS/AAS.aspx");
        }
        if (Page.User.IsInRole("CPM"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20CPM/ACPM.aspx");
        }
        if (Page.User.IsInRole("HR"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20HR/AHR.aspx");
        }
        if (Page.User.IsInRole("Intime"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Intime/AIntime.aspx");
        }
        if (Page.User.IsInRole("KOM"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Kayttoomaisuus/AKayttoomaisuus.aspx");
        }
        if (Page.User.IsInRole("Merlin"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Merlin/AMerlin.aspx");
        }
        if (Page.User.IsInRole("Tikon"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Tikon/ATikon.aspx");
        }
        if (Page.User.IsInRole("Travel"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20TandE/ATandE.aspx");
        }
        if (Page.User.IsInRole("Wintime"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Wintime/AWintime.aspx");
        }
        if (Page.User.IsInRole("Workflow"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Workflow/AWorkflow.aspx");
        }
        if (Page.User.IsInRole("Personec-R"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20Personec-R/APersonec-R.aspx");
        }
        if (Page.User.IsInRole("PersonecW"))
        {
            Response.Redirect("~/DownloadAdmin/Admin%20PersonecW/APersonecW.aspx");
        }
        if (Page.User.IsInRole("Titania"))
        {
            Response.Redirect("~/Download/Titania/Titania.aspx");
        }
        if (Page.User.IsInRole("TitaniaK"))
        {
            Response.Redirect("~/Download/TitaniaK/TitaniaK.aspx");
        }
        if (Page.User.IsInRole("TitaniaM"))
        {
            Response.Redirect("~/Download/TitaniaM/TitaniaM.aspx");
        }
        if (Page.User.IsInRole("TitaniaKM"))
        {
            Response.Redirect("~/Download/TitaniaKM/TitaniaKM.aspx");
        }
        if (Page.User.IsInRole("TitaniaP"))
        {
            Response.Redirect("~/Download/TitaniaP/TitaniaP.aspx");
        }
        if (Page.User.IsInRole("HRMAditrolta"))
        {
            Response.Redirect("~/Download/HRMAditrolta/HRMAditrolta.aspx");
        }
        if (Page.User.IsInRole("HRMAditrolle"))
        {
            Response.Redirect("~/Download/HRMAditrolle/HRMAditrolle.aspx");
        }
        if (Page.User.IsInRole("FRMAditrolta"))
        {
            Response.Redirect("~/Download/FRMAditrolta/FRMAditrolta.aspx");
        }
        if (Page.User.IsInRole("FRMAditrolle"))
        {
            Response.Redirect("~/Download/FRMAditrolle/FRMAditrolle.aspx");
        }
    }
}