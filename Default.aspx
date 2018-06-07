<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="~/Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/UserControls/FileGridCS.ascx" TagName="FileGridVB" TagPrefix="uc1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Sisalto" runat="Server">

    <span id="site_Default" class="site_chosen"></span>
    <div id="tauluvalk"
        
        class="style6">
        <div style="margin-left: 30px; font-family: Calibri; font-weight: lighter; font-size: xx-large; color: #FFAF50; font-style: normal">
            <div class="style8">
                <div style="float: left;">
                    <div id="otsikko" style="padding-top: 5px;">
                        <asp:Literal ID="Literal9" runat="server" Text="Default" />
                    </div>
                </div>
                <div style="float: right;">
                </div>
            </div>
        </div>
    </div>


    <%-- Tiedostolistaus alkaa --%>
    <uc1:FileGridVB ID="FileGridVB1" HomeFolder="~/Download/Default" runat="server" PageSize="10" />
    <%-- Tiedostolistaus loppuu --%>


</asp:Content>
