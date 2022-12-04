<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="SoapeeView.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="justify-content:center; margin-left:auto; margin-right:auto; text-align:center;">Register Page</h1>
    <div class="style-form">
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="style-form">
    <asp:Button ID="registerBtn" CssClass="btn btn-primary" style="width:150px" runat="server" Text="Register" OnClick="registerBtn_Click"/>
    </div>
</asp:Content>
