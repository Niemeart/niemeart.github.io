<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FileGridCSKanta1.ascx.cs" Inherits="UserControls_FileGridCSKanta1" %>

<div id="tauluvalk"
    style=""
    class="style1">
    <asp:GridView ID="gvFiles" runat="server" AutoGenerateColumns="False"
        CellPadding="4" ForeColor="#333333" GridLines="None"
        OnPageIndexChanging="gvFiles_PageIndexChanging"
        OnRowCommand="gvFiles_RowCommand" OnRowDataBound="gvFiles_RowDataBound"
        HorizontalAlign="Left" ShowHeaderWhenEmpty="True" Width="100%">
        <Columns>
            <asp:TemplateField HeaderText="<%$Resources:Main, Tiedostonimi%>" SortExpression="Name">
                <ItemTemplate>
                    <div class="linkki">
                        <asp:LinkButton runat="server" ID="lbFolderItem" CommandName="OpenFolder" CommandArgument='<%# Eval("Name") %>'></asp:LinkButton>
                        <asp:Literal runat="server" ID="ltlFileItem"></asp:Literal>
                        <div class="linkki">
                </ItemTemplate>
                <ControlStyle Font-Names="Calibri" />
                <FooterStyle Font-Names="Calibri" />
                <HeaderStyle HorizontalAlign="Left" CssClass="style3" Font-Names="Calibri" />
                <ItemStyle HorizontalAlign="Left" CssClass="style2" Font-Names="Calibri" />
            </asp:TemplateField>
            <asp:BoundField DataField="FileSystemType" HeaderText="<%$Resources:Main, Tiedostotyyppi%>"
                SortExpression="FileSystemType">
                <HeaderStyle HorizontalAlign="Left" Font-Names="Calibri" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="LastWriteTime" HeaderText="<%$Resources:Main, Muokkauspvm%>"
                SortExpression="LastWriteTime">
                <HeaderStyle HorizontalAlign="Left" Font-Names="Calibri" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="<%$Resources:Main, Koko%>" SortExpression="Size" ItemStyle-HorizontalAlign="Right">
                <ItemTemplate>
                    <%# DisplaySize((long?) Eval("Size")) %>
                </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left" Font-Names="Calibri" />

                <ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#D3D3D3" />
        <FooterStyle BackColor="#507CD1" Font-Bold="False" ForeColor="White" />
        <HeaderStyle Font-Bold="False" ForeColor="White" BackColor="#999999" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle Font-Names="Calibri" ForeColor="#909090" />
        <SelectedRowStyle BackColor="#D3D3D3" Font-Bold="False" ForeColor="#D3D3D3" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</div>
