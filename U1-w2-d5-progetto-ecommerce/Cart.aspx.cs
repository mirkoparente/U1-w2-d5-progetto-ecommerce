using System;
using System.Collections.Generic;
using U1_w2_d5_progetto_ecommerce.Classi;

namespace U1_w2_d5_progetto_ecommerce
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                
                List<Carrello> cart = (List<Carrello>)Session["Cart"];
    
              GridView1.DataSource = cart;
                GridView1.DataBind();
              
            }
            else
            {
                Response.Redirect("Home.aspx");
            }






        }

    }
}