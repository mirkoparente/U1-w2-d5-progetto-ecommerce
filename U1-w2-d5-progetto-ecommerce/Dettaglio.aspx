<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="U1_w2_d5_progetto_ecommerce.Dettaglio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Container">
        <div class="card">
            <div class="row g-0">
                <div class="col-md-4">
                    <asp:Image ID="Image1" runat="server" CssClass="card-img-top  h-100 w-100" />
                </div>
                <div class="col-md-6 h-100">
                    <div class="card-body d-flex justify-content-center align-self-between h-100 flex-grow-1 flex-column ">
                        <div class="d-flex justify-content-start w-100">
                            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="card-title fw-bold me-3"></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="card-text fw-bold"></asp:Label>
                        </div>
                        <asp:Label ID="Label3" runat="server" Text="Label" CssClass="card-text"></asp:Label>
                        <div class="d-flex justify-content-evenly w-100 my-3">
                            <asp:Label ID="Label4" runat="server" Text="Label" CssClass="card-text"></asp:Label>
                            <asp:Label ID="Label5" runat="server" Text="Label" CssClass="card-text fw-bold"></asp:Label>
                        </div>
                        <div class="d-flex justify-content-evenly w-100 my-3">
                            <div class="w-25"></div>
                            <asp:Button ID="Button1" runat="server" Text="AGGIUNGI AL CARRELLO" CssClass=" btn btn-warning" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>



