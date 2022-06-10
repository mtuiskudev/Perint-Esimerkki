using System;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Risteilijä wasa = new Risteilijä(98);

            //Console.WriteLine(wasa.MatkustajaMäärä);
        }
    }


    class Risteilijä
    {
        public int MatkustajaMäärä;
        public string Moottori;

        public Risteilijä(int maara)
        {
            this.MatkustajaMäärä = maara;
        }

    }
}
