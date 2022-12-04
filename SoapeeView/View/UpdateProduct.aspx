<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="SoapeeView.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1 style="justify-content:center; margin-left:auto; margin-right:auto; text-align:center;">Update Product</h1>
    <div class="style-form">
    <asp:Label ID="Label1" runat="server" Text="Product Name" Font-Names="Arial Unicode MS"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="Label2" runat="server" Text="Product Price" Font-Names="Arial Unicode MS"></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </div>
    <div class="style-form">
    <asp:Label ID="Label3" runat="server" Text="Product Description" Font-Names="Arial Unicode MS"></asp:Label>
    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="style-form">
    <asp:Button ID="btnUpdate" CssClass="btn btn-primary" style="width:150px" runat="server" Text="Update Product" OnClick="btnUpdate_Click"/>
    </div>
</asp:Content>
