using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DownloadKanta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.User.IsInRole("Admin"))
        {

            
            string allowedExtensions = ".config,.aspx,.css,.cs,.db";
            // KIELLETYT TIEDOSTOPÄÄTTEET

            string fileName = "";
            string filePath = "";
            if (Request.QueryString["file"] != null) fileName = Request.QueryString["file"].ToString();
            if (Request.QueryString["path"] != null) filePath = Request.QueryString["path"].ToString();
            if (fileName != "" && fileName.IndexOf(".") > 0)
            {
                bool extensionAllowed = false;
                string fileExtension = fileName.Substring(fileName.LastIndexOf('.'), fileName.Length - fileName.LastIndexOf('.'));

                string[] extensions = allowedExtensions.Split(',');
                for (int a = 0; a < extensions.Length; a++)
                {
                    if (extensions[a] == fileExtension)
                    {
                        extensionAllowed = true;
                        break;
                    }
                }

                if (extensionAllowed == false)
                {
                    if (File.Exists(Server.MapPath(filePath + '/' + fileName)))
                    {
                        if (Request.UserAgent.ToLower().Contains("iphone") || Request.UserAgent.ToLower().Contains("ipad")) { Response.Redirect(filePath + '/' + fileName); }

                        Response.Clear();
                        int lastKenoPos = fileName.LastIndexOf('/');
                        string trimFileName = fileName.Substring(lastKenoPos + 1);
                        //Response.AddHeader("content-disposition", "attachment;filename=" + fileName);
                        Response.AddHeader("Content-Disposition", "attachment;filename=" + trimFileName);
                        Response.TransmitFile(Server.MapPath(filePath + '/' + fileName));
                        if ((Page.User.IsInRole("User")) || (Page.User.IsInRole("Kanta")))
                        {
                            Response.Flush();
                            System.IO.File.Delete(Server.MapPath(filePath + '/' + fileName));
                        }
                        Response.End();
                    }
                    else
                    {
                        litMessage.Text = "File could not be found";
                    }
                }
            }
            else
            {
                litMessage.Text = "Error - no file to download";
            }
        }
    }
}
