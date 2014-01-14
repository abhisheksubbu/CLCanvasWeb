<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbl_Greet" runat="server" Text="Label"></asp:Label>
    <div style="width:1100px;">
        <iframe id="connectleaderVP" runat="server" width="640px" height="600px" src="http://www.connectleader.com"></iframe>
        <iframe id="salesforceVP" runat="server" width="640px" height="600px"></iframe>
    </div>

</asp:Content>

