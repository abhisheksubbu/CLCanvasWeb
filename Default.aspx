<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbl_Greet" runat="server" Text="Label"></asp:Label>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <telerik:RadSplitter ID="RadSplitter1" runat="server" Width="100%" Height="650px">
        <telerik:RadPane ID="RadPane1" runat="server">
            <iframe id="connectleaderVP" runat="server" width="100%" height="100%" src="https://www.connectleader.com"></iframe>
        </telerik:RadPane>
        <telerik:RadSplitBar ID="RadSplitBar1" runat="server"
            CollapseMode="Both" />
        <telerik:RadPane ID="RadPane5" runat="server">
            <iframe id="salesforceVP" runat="server" width="100%" height="100%"></iframe>
        </telerik:RadPane>
    </telerik:RadSplitter>
</asp:Content>

