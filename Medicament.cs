using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Medicament
    {
        private string nume;
        int nrstocuri;
        int nrcomprimate;
        
        public Medicament(string sir)
        {
            string[] date = sir.Split(',');
            this.nume = date[0];
            this.nrstocuri = Convert.ToInt32(date[1]);
            this.nrcomprimate = Convert.ToInt32(date[2]);
        }

        public string conversieLaSir()
        {
            return $" Nume:{nume}, Nrstocuri: {nrstocuri}, NrComprimate: {nrcomprimate}";
        }

        public string compare(Medicament a, Medicament b)
        {
            if(a.nrcomprimate > b.nrcomprimate)
            {
                return $"Primul medicament e mai mare";
            } else if (a.nrcomprimate < b.nrcomprimate){
                return $"Al doilea medicament e mai mare";
            }
            return "Medicamentele au aceleasi numar de comprimante";
        }

    }
}
