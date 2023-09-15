using System;
using System.Collections.Generic;

namespace U1_w2_d5_progetto_ecommerce.Classi
{
    public class Prodotti
    {
        public int IdProd { get; set; }
        public string Nome { get; set; }
        public string DescBreve { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public string ImgProd { get; set; }
        public double PrezzoScont {  get; set; }

        public static List<Prodotti> ListaProdotti = new List<Prodotti>();

        public static List<Carrello> listaCarrello = new List<Carrello>();

        public Prodotti() { }

        public Prodotti(int id,string nome, string descB, string descrizione, double prezzo, string img,double prezzoScont)
        {
            IdProd = id;
            Nome = nome;
            DescBreve = descB;
            Descrizione = descrizione;
            Prezzo = prezzo;
            ImgProd = img;
            PrezzoScont = prezzoScont;
        }
        public  static void ListaP()
        {
            ListaProdotti.Add(new Prodotti(1,"Iphone", "14 pro",
                "Apple iPhone 14 Pro può registrare video in modalità 4K@24/30/60fps, 1080p@30/60; la fotocamera frontale, inserita in una notch nel display, è da 12 MP, f/1.9, 23mm (grandangolare). Apple iPhone 14 Pro integra una batteria da 3200mAh di capacità, con tecnologia di ricarica da Fino a 30W.",
                1400,
                "data:image/jpeg;base64,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",1200));
            ListaProdotti.Add(new Prodotti(2,"Samsung", "S-22 Ultra", "Storage: 128 GB. Connettività:5G LTE, NFC, Bluetooth 5.0, GPS, GLONASS, Beidou, Galileo, Wi-Fi 6E (2.4/5/6 GHz), lettore di impronte digitali ultrasonico sotto lo schermo, riconoscimento facciale, USB Tipo C. Batteria da 3700 mAh compatibile con 25W di carica veloce, 15W di carica wireless."
                , 900,
                "https://cdn.idealo.com/folder/Product/201734/5/201734572/s10_produktbild_gross_16/samsung-galaxy-s22-ultra.jpg",800));
            ListaProdotti.Add(new Prodotti(3,"Lenovo", "Legion", "Affronta la competizione con Legion 5 Gen 6 (15\" AMD). Questo dispositivo ti offre tutto il necessario per vincere contro qualsiasi avversario, tra cui processori per dispositivi mobili fino ad AMD Ryzen™ 7 5800H e scheda grafica NVIDIA® GeForce RTX™ serie 30. Goditi immagini nitidissime sullo schermo fino a WQHD da 38,1 cm (15\"), con un'incredibile precisione cromatica e Dolby Vision™, mentre l'audio 3D Nahimic e la tastiera Legion TrueStrike ti aiutano a colpire con la massima precisione."
           , 2000,
           "https://p4-ofp.static.pub/fes/cms/2022/05/04/8fnscbykfewbtz3bajjq0578ic4p3x638664.png",1700)); 
            ListaProdotti.Add(new Prodotti(4,"MSI", "Katana", "MSI Katana GF66 12UD-074IT, Notebook Gaming, 15.6\" FHD 144Hz, Intel I7-12700H, Nvidia RTX 3050Ti 4GB GDDR6, 16GB RAM DDR4 3200MHz, 1TB SSD M. 2 PCIe 4.0, WiFi 6, Win 11 Home [Layout e Garanzia ITA]"
           , 1700,
           "https://m.media-amazon.com/images/I/713dZHEY2YL._AC_UF1000,1000_QL80_.jpg",1600));

        }
        

        public static List<Carrello> AggiungiCarrello(int id)
        {
            

            List<Carrello> c = new List<Carrello>();


            foreach (Prodotti p in Prodotti.ListaProdotti)
            {

                if (id == p.IdProd)
                {
                    int idC = p.IdProd;
                    string nome = p.Nome;
                    string descB = p.DescBreve;
                    double prezzo = p.Prezzo;
                    string img = p.ImgProd;

                    Carrello c2 = new Carrello(idC, nome, descB, prezzo, img);
                    c.Add(c2);

                    
                }

            }
            return c;
        }

    }
}