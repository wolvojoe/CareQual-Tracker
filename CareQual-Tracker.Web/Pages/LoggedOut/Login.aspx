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
              <input type="email" class="form-control" placeholder="Email" />
              <div class="input-group-text">
                <span class="bi bi-envelope"></span>
              </div>
            </div>
            <div class="input-group mb-3">
              <input type="password" class="form-control" placeholder="Password" />
              <div class="input-group-text">
                <span class="bi bi-lock-fill"></span>
              </div>
            </div>
            <!--begin::Row-->
            <div class="row">
              <div class="col-8">
                <div class="form-check">
                  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault" />
                  <label class="form-check-label" for="flexCheckDefault"> Remember Me </label>
                </div>
              </div>
              <!-- /.col -->
              <div class="col-4">
                <div class="d-grid gap-2">
                  <button type="submit" class="btn btn-primary">Sign In</button>
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
