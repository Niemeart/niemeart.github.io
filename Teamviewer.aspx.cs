using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Teamviewer_Teamviewer : BasePageT
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Attributes.Add("onclick", "document.body.style.cursor = 'wait';");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        if (IsPostBack)
        {
            if (Page.User.IsInRole("Admin"))
            {
                String path = Server.MapPath("~/Download/Teamviewer/");
                if (FileUpload1.HasFile)
                {
                    try
                    {
                        FileUpload1.PostedFile.SaveAs(path
                            + FileUpload1.FileName);
                        Label1.Text = (string)HttpContext.GetGlobalResourceObject("Main", "Lahetetty");
                    }
                    catch (Exception)
                    {
                        Label1.Text = "Tiedostoa ei voitu ladata.";
                    }
                }
            }
            else
            {

                        Label1.Text = "Tiedostoa ei voitu ladata.";
            }
        }
    }
}