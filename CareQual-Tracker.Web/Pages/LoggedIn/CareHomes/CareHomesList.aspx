<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="CareHomesList.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.LoggedIn.CareHomes.CareHomesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageName" runat="server">
        <h3 class="mb-0">Care Homes</h3>
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

                        <asp:UpdatePanel ID="upnCareHomes" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvCareHomes" runat="server"
                                        CssClass="table table-bordered"
                                        AutoGenerateColumns="false"
                                        EmptyDataText="No care homes found."
                                        AllowPaging="true"
                                        PageSize="5"
                                        OnPageIndexChanging="gvCareHomes_PageIndexChanging"
                                        DataKeyNames="CareHomeId"
                                        PagerStyle-CssClass="bootstrap-pager"
                                        PagerSettings-Mode="NumericFirstLast"
                                        PagerSettings-Position="Bottom">
                                        

                                    <Columns>
                                        <asp:BoundField HeaderText="Name" DataField="CareHomeName" />

                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="float-end">

                                                    <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" NavigateUrl='<%# GetRouteUrl("CareHome", new { id = Eval("CareHomeId") }) %>' CssClass="px-2 text-primary" style="text-decoration : none;">
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
