﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbl_Greet" runat="server" Text="Label"></asp:Label>
    <div>
        <iframe id="connectleaderVP" runat="server" width="50%"></iframe>
        <iframe id="salesforceVP" runat="server" width="50%"></iframe>
    </div>

</asp:Content>

