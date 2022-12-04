<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SoapeeView.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="images-gallery row mt-1">
            <asp:Repeater ID="rptProduct" runat="server" OnItemCommand="rptProduct_ItemCommand" OnItemDataBound="rptProduct_ItemDataBound">
                <ItemTemplate>
                    <div class="cols-sm-2 col-md-3 product-grid" >
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title" style="font-size:30px"><%# Eval("Name") %></h5>
                                <p class="card-text"><%# Eval("Description") %></p>
                                <p class="card-text">Rp. <%# Eval("Price") %>,-</p>
                                <div id="add_cart" class="btn-card" runat="server">
                                    <asp:Button ID="btnMinus" CssClass="btn btn-danger btn-sm" OnClick="btnMinus_Click" runat="server" Text="-" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                    <asp:Button ID="btnAdd"  CssClass="btn btn-info btn-sm" OnClick="btnAdd_Click" runat="server" Text="+" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                </div>
                                <div id="admin_view" class="btn-card" runat="server">
                                    <asp:Button ID="btnUpdate" CssClass="btn btn-info btn-sm" OnClick="btnUpdate_Click" runat="server" Text="Update Product" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                    <asp:Button ID="btnRemove" CssClass="btn btn-danger btn-sm" OnClick="btnRemove_Click" runat="server" Text="Remove Product" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
                <div id="admin_view" class="btn-card" runat="server">
                    <asp:Button ID="btnInsert" CssClass="btn btn-success" OnClick="btnInsert_Click" runat="server" Text="Insert Product" />
                </div>
        </div>
    </div>
</asp:Content>
