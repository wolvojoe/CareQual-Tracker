<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedIn.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.LoggedIn.Administration.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphPageName" runat="server">
        <h3 class="mb-0">Qualifications</h3>
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

                        <asp:GridView ID="gvQualifications" runat="server"
                                      CssClass="table table-bordered"
                                      AutoGenerateColumns="false"
                                      EmptyDataText="No qualifications found."
                                      AllowPaging="true"
                                      PageSize="20"
                                      OnPageIndexChanging="gvQualifications_PageIndexChanging"
                                      DataKeyNames="QualificationId">


                            <Columns>
                                <asp:BoundField HeaderText="Name" DataField="Name"/>
                                <asp:BoundField HeaderText="AwardingBody" DataField="AwardingBody"/>

                                <asp:TemplateField>
                                  <ItemTemplate>
                                   <asp:HyperLink ID="hlEdit" runat="server" Text="Edit"  NavigateUrl='<%# GetRouteUrl("Qualification", new { id = Eval("QualificationId") }) %>'>
                                       <i class="bi bi-pencil-square"></i>
                                   </asp:HyperLink>

                                   <asp:LinkButton ID="lbtnDelete" runat="server" Text="Delete" OnCommand="lbtnDelete_Command" CommandArgument='<%# Eval("QualificationId") %>'>
                                       <i class="bi bi-x-circle"></i>
                                   </asp:LinkButton>
                                  </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                    <!-- /.card-body -->
                    <div class="card-footer clearfix">



                        <ul class="pagination pagination-sm m-0 float-end">
                            <li class="page-item">
                                <a class="page-link" href="#">«</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="#">1</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="#">2</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="#">3</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="#">»</a>
                            </li>
                        </ul>
                    </div>
                </div>

                <!-- /.card -->
            </div>

        </div>
    </div>

</asp:Content>
