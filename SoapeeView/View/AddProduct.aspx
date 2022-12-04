<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="SoapeeView.View.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="justify-content:center; margin-left:auto; margin-right:auto; text-align:center;">Insert Product</h1>
    <div class="style-form">
    <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="Label2" runat="server" Text="Product Price"></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="Label3" runat="server" Text="Product Description"></asp:Label>
    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="style-form">
    <asp:Button ID="btnAdd" CssClass="btn btn-primary" style="width:150px" runat="server" Text="Insert Product" OnClick="btnAdd_Click"/>
    </div>
</asp:Content>
