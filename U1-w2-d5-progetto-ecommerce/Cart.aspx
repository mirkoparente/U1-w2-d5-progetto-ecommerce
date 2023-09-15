<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="U1_w2_d5_progetto_ecommerce.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:GridView ID="GridView1" CssClass="table table-bordered table-striped table-warning" runat="server" AutoGenerateColumns="true" ItemType="U1_w2_d5_progetto_ecommerce.Classi.Carrello">
    <Columns>
       <asp:TemplateField>
           <HeaderTemplate>
               <b>Prodotto</b>
           </HeaderTemplate>
           <ItemTemplate>
               <img src="<%# Item.Prodotto.ImgProd %>" class="w-25" alt="Alternate Text" />
           </ItemTemplate>
       </asp:TemplateField>
    </Columns>
       <Columns>
       <asp:TemplateField>
           <HeaderTemplate>
               <b>Nome Prodotto</b>
           </HeaderTemplate>
           <ItemTemplate>
             <%# Item.Prodotto.Nome %>
           </ItemTemplate>
       </asp:TemplateField>
    </Columns> 
       <Columns>
       <asp:TemplateField>
           <HeaderTemplate>
               <b>Descrizione Prodotto</b>
           </HeaderTemplate>
           <ItemTemplate>
             <%# Item.Prodotto.DescBreve %>
           </ItemTemplate>
       </asp:TemplateField>
    </Columns>  
       <Columns>
       <asp:TemplateField>
           <HeaderTemplate>
               <b>Prezzo</b>
           </HeaderTemplate>
           <ItemTemplate>
             <%# Item.Prodotto.Prezzo %> €
           </ItemTemplate>
       </asp:TemplateField>
    </Columns>

</asp:GridView>
   
         
        
</asp:Content>
