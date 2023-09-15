using System;
using System.Collections.Generic;


namespace U1_w2_d5_progetto_ecommerce.Classi
{
    public class Carrello
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DescBreve { get; set; }
        public double Prezzo { get; set; }
        public string ImgProd { get; set; }
        public Carrello() { }
        public Carrello(int id,string nome, string descBreve, double prezzo, string imgProd)
        {
            Id = id;
            this.Nome = nome;
            this.DescBreve = descBreve;
            this.Prezzo = prezzo;
            this.ImgProd = imgProd;
        }
    }
}