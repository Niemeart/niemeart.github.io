<%@ Page Title="" Language="C#" MasterPageFile="~/SiteT.master" AutoEventWireup="true" CodeFile="~/Teamviewer.aspx.cs" Inherits="Teamviewer_Teamviewer" %>

<%@ Register Src="~/UserControls/FileGridCS.ascx" TagName="FileGridVB" TagPrefix="uc1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Sisalto" runat="Server">

    <span id="site_nTeamviewer" class="site_chosen"></span>
    <div id="tauluvalk"
        
        class="style6">
        <div style="margin-left: 30px; font-family: Calibri; font-weight: lighter; font-size: xx-large; color: #FFAF50; font-style: normal">
            <div class="style8">
                <div style="float: left;">
                    <div id="otsikko" style="padding-top: 5px;">
                        Teamviewer
                    </div>
                </div>
                <div style="float: right;">
                    <asp:Label ID="Label1" runat="server" Style="height: 23px;" Font-Size="Large" />
                    <asp:FileUpload ID="FileUpload1" runat="server" BackColor="White"
                        Font-Names="Calibri" CssClass="Tiedosto" />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="<%$Resources:Main, Laheta%>"
                        Font-Names="Calibri" CssClass="Laheta" />&nbsp;&nbsp;
                </div>
            </div>
        </div>
    </div>



    <%-- Tiedostolistaus alkaa --%>
    <uc1:FileGridVB ID="FileGridVB1" HomeFolder="~/Download/Teamviewer" runat="server" PageSize="10" />
    <%-- Tiedostolistaus loppuu --%>



</asp:Content>

