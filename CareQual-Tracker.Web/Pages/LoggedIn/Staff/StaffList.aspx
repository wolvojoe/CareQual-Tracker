<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.LoggedIn.Staff.StaffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageName" runat="server">
    <h3 class="mb-0">Care Staff</h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="server">

    <div class="container-fluid">
        <div class="row">

            <div class="col-md-12">
                <div class="card mb-4">
                    <div class="card-header">
                        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" CssClass="btn btn-primary float-end" Text="Create" />
                    </div>
                    <!-- /.card-header -->
                    <div class="card-body">

                        <asp:UpdatePanel ID="upnCareStaff" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvCareStaff" runat="server"
                                        CssClass="table table-bordered"
                                        AutoGenerateColumns="false"
                                        EmptyDataText="No care staff found."
                                        AllowPaging="true"
                                        PageSize="5"
                                         OnPageIndexChanging="gvCareStaff_PageIndexChanging"
                                        DataKeyNames="CareStaffId"
                                        PagerStyle-CssClass="bootstrap-pager"
                                        PagerSettings-Mode="NumericFirstLast"
                                        PagerSettings-Position="Bottom">
                                        

                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                
                                                <%# Eval("FullName") %>

                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="float-end">

                                                    <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" NavigateUrl='<%# GetRouteUrl("CareHome", new { id = Eval("StaffId") }) %>' CssClass="px-2 text-primary" style="text-decoration : none;">
                                                        <i class="bi bi-pencil-square"></i>
                                                    </asp:HyperLink>

                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </div>


                </div>

                <!-- /.card -->
            </div>

        </div>
    </div>

</asp:Content>
