using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop2
{
    internal class Acqua : Prodotto
    {
        public int litri;
        private int ph;
        private string sorgente;
        public int litriDaBere;



        public Acqua(string nome, string descrizione, int prezzo, int iva, int litri, int ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            this.litriDaBere = litriDaBere;
        }
        public int infolitri
        {
            get { return this.litri; }
            set { this.litri = value; }
        }
        public int infoPh
        {
            get { return this.ph; }


        }
        public string infoSorgente
        {
            get { return this.sorgente; }

        }
        public int infolitriDaBere
        {
            get { return this.litriDaBere; }
            set { this.litriDaBere = value; }
        }
        public int Bevi()
        {
            if (this.litriDaBere <= this.litri)
            {

                return this.litri = this.litri - this.litriDaBere;
            }
            else
            {
                Console.WriteLine("non è presente abbastanza acqua");
            }
            return this.litri;




        }


    }
}
