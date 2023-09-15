<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="U1_w2_d5_progetto_ecommerce.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-warning-subtle pb-5 flex-grow-1">
        <div class="d-flex justify-content-center">
            <a
                href="Home.aspx"
                class="text-center text-decoration-none fs-2 text-warning">
                <img
                    src="Content/img/crudazon__1_-removebg-preview%20(1).png"
                    class="w-25"
                    alt="" />
                Dalla C alla Z</a>
        </div>
        <div class="Container">
            <div class="row row-cols-4">
                <asp:Repeater ID="Repeater1" runat="server" ItemType="U1_w2_d5_progetto_ecommerce.Classi.Prodotti">
                    <ItemTemplate>
                        <div class="col ">
                            <div class="card border border-warning h-100 ">
                                <div class="h-75 text-center">
                                    <img src="<%# Item.ImgProd  %>" class="card-img-top h-75 w-75" id="pos" alt="...">
                                </div>
                                <div class="card-body text-center ">
                                    <h5 class="card-title"><%# Item.Nome %></h5>
                                    <p class="card-text"><%# Item.DescBreve  %></p>
                                    <div class="d-flex justify-content-between align-items-center ">
                                    <a href="Dettaglio.aspx?IdProd=<%# Item.IdProd %>" class="btn btn-primary">Dettagli </a>
                                    <p class="card-text">€ <%# Item.Prezzo  %></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
