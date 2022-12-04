<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="SoapeeView.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4 justify-content-center product-detail">
            <asp:Repeater ID="rptCart" runat="server">
                <ItemTemplate>
                    <div class="card mb-3" style="width: 100%">
                      <div class="row g-0">
                        
                        <div class="col-md-4" style="display: flex; flex-direction: column; justify-content:center">
                          <div class="card-body" style="display: flex; flex-direction: column; justify-content:center">
                            <h5 class="form-label mb-3" style="margin-bottom: 8px"><%# Eval("Name") %></h5>
                            <p class="form-label"><%# Eval("Description") %></p>
                            <p class="form-label">Rp. <%# Eval("Price") %>,- </p>
                            <div class="mb-3">
                                <div class="input-group mt-2">
                                    <div class="input-group-prepend ">
                                        <div class="input-group-text">Qty</div>
                                    </div>
                                    <asp:TextBox ID="tbQuantity" type="number" CommandArgument='...' Text=<%# Eval("Quantity") %> CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                            </div>
                  
                            <div class="row justify-content-around mt-3">
                                <asp:Button CssClass="btn btn-primary" style="width:150px" ID="btnMinus" runat="server" Text="-" CommandName="..." OnClick="minusBtn_Click" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False"/>
                                <asp:Button CssClass="btn btn-danger" style="width:150px" ID="btnAdd" runat="server" Text="+" CommandName="..." OnClick="addBtn_Click" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False"/>
                            </div>
                            <div class="row justify-content-around mt-3">
                                <asp:Button CssClass="btn btn-success" style="width:150px" ID="btnRemove" runat="server" Text="Remove" CommandName="..." OnClick="btnRemove_Click" CommandArgument='<%# Eval("ProductId") %>' UseSubmitBehavior="False"/>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="row justify-content-center">
                <asp:Button CssClass="btn btn-success" style="width:200px" ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
            </div>
    </div>
</asp:Content>
