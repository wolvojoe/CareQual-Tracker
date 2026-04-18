<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoggedOut.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CareQual_Tracker.Web.Pages.LoggedOut.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="login-box">
        <div class="login-logo">
            <img src="../../Logos/CareQualLogo-Tran.jpg"
                alt="CareQual Tracker Logo"
                class="brand-image opacity-75 shadow w-25" />

        </div>
        <!-- /.login-logo -->
        <div class="card">
            <div class="card-body login-card-body">
                <div class="input-group mb-3">
                    <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control" placeholder="Email Address"></asp:TextBox>
                    <div class="input-group-text">
                        <span class="bi bi-envelope"></span>
                    </div>
                </div>
                <div class="input-group mb-3">
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
                    <div class="input-group-text">
                        <span class="bi bi-lock-fill"></span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-12">
                        <asp:Panel runat="server" ID="pnlLoginError" CssClass="alert alert-danger" Visible="false">
                            <asp:Label runat="server" ID="lblLoginError">
                            </asp:Label>
                        </asp:Panel>
                    </div>
                </div>
                <!--begin::Row-->
                <div class="row">
                    <div class="col-8">
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault" />
                            <label class="form-check-label" for="flexCheckDefault">Remember Me </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-4">
                        <div class="d-grid gap-2">
                            <asp:Button runat="server" ID="btnLogin" Text="Sign In" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                        </div>
                    </div>
                    <!-- /.col -->
                </div>
                <!--end::Row-->

            </div>
            <!-- /.login-card-body -->
        </div>
    </div>
    <!-- /.login-box -->


</asp:Content>
