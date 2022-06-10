using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Luokka
    {
        static void Main(string[] args)
        {
            RahtiLaiva paatti = new RahtiLaiva();
            paatti.KirjoitaLokiKirjaan("Alus luotu");
            paatti.Nimi = "Kuormalaiva";
            paatti.LastiaKyytiin("Leipää");
            paatti.RahtiMäärä = 100;

            Risteilijä wasa = new Risteilijä(100);
            wasa.Nimi = "Wasa";
            wasa.KirjoitaLokiKirjaan("Matkustaja-alus luotu");
            wasa.Maali = "Hampuri";


            List<Alus> alusRekisteri = new List<Alus>();
            alusRekisteri.Add(paatti);
            alusRekisteri.Add(wasa);
            Tankkeri tankki = new Tankkeri();



            double rahtiTarkistus = (alusRekisteri[0] as RahtiLaiva).RahtiMäärä;

            string maaliTarkistus = alusRekisteri[1].Maali;

            Console.WriteLine(alusRekisteri[0].Nimi + " jolla lastia "+ rahtiTarkistus );

            Console.WriteLine(alusRekisteri[1].Nimi + " jolla maalina "+ maaliTarkistus);


        }

        
    }

    class Alus
    {
        public string Nimi;
        public double Nopeus;
        public string Maali;
        List<string> LokiKirja = new List<string>();
        

        public void KirjoitaLokiKirjaan(string teksti)
        {
            this.LokiKirja.Add(teksti);
        }

        public string PalautaLokiKirja()
        {
            string loki = "";
            foreach(string kirjaus in this.LokiKirja)
            {
                loki = loki + kirjaus + Environment.NewLine;
            }
            return loki;
        }
    }

    class RahtiLaiva: Alus
    {
        public double RahtiMäärä;
        List<string> Lasti = new List<string>();
        
        public void LastiaKyytiin(string tavara)
        {
            this.Lasti.Add(tavara);
        }


    }

    class Risteilijä: Alus
    {
        public int MatkustajaMäärä;

        public Risteilijä(int maara)
        {
            this.MatkustajaMäärä = maara;
        }

    }

    class Tankkeri: RahtiLaiva
    {
        int numero;

    }

}
