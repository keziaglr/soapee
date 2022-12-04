<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SoapeeView.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="justify-content:center; margin-left:auto; margin-right:auto; text-align:center;">Login Page</h1>
    <div class="style-form">
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div class="style-form">
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="style-form">
        <asp:Button ID="loginBtn" CssClass="btn btn-primary" style="width:150px" runat="server" Text="Login" OnClick="loginBtn_Click"/>
    </div>
    
</asp:Content>
