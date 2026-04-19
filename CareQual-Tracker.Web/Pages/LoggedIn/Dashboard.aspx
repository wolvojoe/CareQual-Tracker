<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.Dashboard" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="server">

</asp:Content>


<asp:Content ID="ctPageName" ContentPlaceHolderID="cphPageName" runat="server">
    <h3 class="mb-0">Dashboard</h3>
</asp:Content>


<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="server">
    <button type="button" class="btn btn-primary mb-2">Primary</button>
</asp:Content>
