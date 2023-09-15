using System;
using System.Collections.Generic;
using U1_w2_d5_progetto_ecommerce.Classi;

namespace U1_w2_d5_progetto_ecommerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Prodotti.ListaProdotti.Clear();
                Prodotti.ListaP();

                List<Prodotti> pr = new List<Prodotti>();

                foreach (Prodotti p in Prodotti.ListaProdotti)
                {
                    pr.Add(p);
                }

                Repeater1.DataSource = pr;
                Repeater1.DataBind();
            }
            



        }
    }


}