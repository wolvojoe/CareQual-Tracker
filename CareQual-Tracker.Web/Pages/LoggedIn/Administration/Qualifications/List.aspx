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

                        <asp:UpdatePanel ID="upnQualificationGrid" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvQualifications" runat="server"
                                        CssClass="table table-bordered"
                                        AutoGenerateColumns="false"
                                        EmptyDataText="No qualifications found."
                                        AllowPaging="true"
                                        PageSize="5"
                                        OnPageIndexChanging="gvQualifications_PageIndexChanging"
                                        DataKeyNames="QualificationId"
                                        PagerStyle-CssClass="bootstrap-pager"
                                        PagerSettings-Mode="NumericFirstLast"
                                        PagerSettings-Position="Bottom">
                                        

                                    <Columns>
                                        <asp:BoundField HeaderText="Name" DataField="Name" />
                                        <asp:BoundField HeaderText="Awarding Body" DataField="AwardingBody" />

                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="float-end">

                                                    <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" NavigateUrl='<%# GetRouteUrl("Qualification", new { id = Eval("QualificationId") }) %>' CssClass="px-2 text-primary" style="text-decoration : none;">
                                                        <i class="bi bi-pencil-square"></i>
                                                    </asp:HyperLink>

                                                    <asp:LinkButton ID="lbtnDelete" runat="server" Text="Delete" OnCommand="lbtnDelete_Command" CommandArgument='<%# Eval("QualificationId") %>' OnClientClick="return confirmDelete(this);" CssClass="px-2 text-danger">
                                                        <i class="bi bi-x-circle"></i>
                                                    </asp:LinkButton>

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


    <script>
        function confirmDelete(btn) {
            Swal.fire({
                title: 'Are you sure?',
                text: "This record will be deleted.",
                icon: 'error',
                showCancelButton: true,
                confirmButtonText: 'Yes, delete it!',
                confirmButtonColor: '#64418c',
                cancelButtonText: 'Cancel'
            }).then((result) => {
                if (result.isConfirmed) {
                    eval(btn.href);
                }
            });

            return false;
        }
</script>
</asp:Content>
