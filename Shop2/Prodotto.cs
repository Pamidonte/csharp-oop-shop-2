using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop2
{
    internal class Prodotto
    {
        Random rnd = new Random();
        public int codice;
        public string nome;
        public string descrizione;
        public int prezzo;
        public int iva;

        public Prodotto(string nome, string descrizione, int prezzo, int iva)
        {
            this.codice = rnd.Next(0, 10000000);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        public int infoCodice
        {
            get { return this.codice; }
        }
        public string infoNome
        {
            get { return this.nome; }
            set { this.nome = value; }

        }
        public string infoDescrizione
        {
            get { return this.descrizione; }
            set { this.descrizione = value; }
        }
        public int infoPrezzo
        {
            get { return this.prezzo; }
            set { this.prezzo = value; }
        }
        public int infoIva
        {
            get { return this.iva; }
            set { this.iva = value; }
        }
        public decimal prezzoIva()
        {
            decimal percentualeIva = (this.prezzo * this.iva) / 100m;
            return (this.prezzo + percentualeIva);
        }
        public string nomePiuCodice()
        {
            return this.codice.ToString() + this.nome;
        }
        public string metodoPadLeft()
        {
            return this.codice.ToString().PadLeft(8, '0');
        }

    }
}



