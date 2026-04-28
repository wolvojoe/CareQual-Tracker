<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="CareHome.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.LoggedIn.CareHomes.CareHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageName" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="server">



   <div class="container-fluid">
       <div class="row">
            <asp:UpdatePanel ID="upnCareHomeDetails" runat="server">
                <ContentTemplate>
                   <div class="col-12">
                       <div class="card card-primary card-outline mb-4 careQual-card-custom">
                           <div class="card-header">
                               <div class="card-title">Care Home Details</div>
                           </div>
                           <div class="card-body">
                               <asp:ValidationSummary ID="vsSummary" runat="server" CssClass="text-danger mb-3" HeaderText="Please correct the following:" />
                               <asp:HiddenField ID="hfCareHomeId" runat="server" />

                               <div class="mb-3">
                                   <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" CssClass="form-label">Name</asp:Label>
                                   <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                                   <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required." CssClass="text-danger" Display="Dynamic" />
                               </div>

                           </div>

                           <div class="card-footer">
                               <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
                               <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-secondary ms-2" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />
                           </div>
                       </div>
                   </div>
                </ContentTemplate>
            </asp:UpdatePanel>
       </div>
   </div>

</asp:Content>
