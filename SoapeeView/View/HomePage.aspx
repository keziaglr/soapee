<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SoapeeView.View.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="images-gallery row mt-1">
            <asp:Repeater ID="rptProduct" runat="server" OnItemCommand="rptProduct_ItemCommand" OnItemDataBound="rptProduct_ItemDataBound">
                <ItemTemplate>
                    <div class="cols-sm-2 col-md-3 product-grid" >
                        <div class="card" style="width: 16rem; padding:8px">
                            <div class="card-body">
                                <%--Show product name--%>
                                <h5 class="card-title"><%# Eval("Name") %></h5>
                                <%--Show short product description--%>
                                <p class="card-text"><%# Eval("Description") %></p>
                                <%--Show product price--%>
                                <p class="card-text">Rp. <%# Eval("Price") %>,-</p>
                                <div id="add_cart" class="btn-card" runat="server">
                                    <asp:Button ID="minusBtn" CssClass="btn btn-danger btn-sm" OnClick="minusBtn_Click" runat="server" Text="-" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                    <asp:Button ID="addBtn" CssClass="btn btn-info btn-sm" OnClick="addBtn_Click" runat="server" Text="+" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
