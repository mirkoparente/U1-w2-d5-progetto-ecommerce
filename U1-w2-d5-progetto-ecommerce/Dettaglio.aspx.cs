using System;
using U1_w2_d5_progetto_ecommerce.Classi;

namespace U1_w2_d5_progetto_ecommerce
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["IdProd"]);
            foreach (Prodotti p in Prodotti.ListaProdotti)
            {

                if (id == p.IdProd)
                {

                    Image1.ImageUrl = p.ImgProd;
                    Label1.Text = p.Nome;
                    Label2.Text = p.DescBreve;
                    Label3.Text = $"<strong>Caratteristiche Prodotto:</strong> <br> {p.Descrizione}";
                    Label4.Text = $"<del>Prezzo Precedente: {p.Prezzo.ToString("C2")}</del>";
                    Label5.Text = $"Prezzo Scontato: {p.PrezzoScont.ToString("C2")} €";

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["IdProd"]);

            Prodotti.AggiungiCarrello(id);

            Session["Cart"] = Prodotti.AggiungiCarrello(id);
        }

    }

}
       
    }
}