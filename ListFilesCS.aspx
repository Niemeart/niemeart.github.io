<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListFilesCS.aspx.cs" Inherits="ListFilesCS" %>

<%@ Register Src="UserControls/FileGridCS.ascx" TagName="FileGridVB" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Sisalto" runat="Server">
    <uc1:FileGridVB ID="FileGridVB1" HomeFolder="~/Download/TandE" runat="server" PageSize="10" />
</asp:Content>

