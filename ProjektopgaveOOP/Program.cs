using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektopgaveOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string Kunde0001 = ("kunde{0}", id);

            Kunder Kunde0001 = new Kunder("Erhverv", "12/12-2010", "Flere biler");

            //Cat C1 = new Cat("Tigermancat", "42", "Norway'nt", "Meooooooooow");
            //Fish F1 = new Fish("Sea Linguini", "124", "Sealand");
            //Bird B1 = new Bird("Eaglebird", "4", "Afrika'nt", "Pipipipipipipipipip");

            Console.WriteLine(Kunde0001.Biler);

            //Console.WriteLine(C1.FuldDyreInfo());
            //Console.WriteLine(F1.FuldDyreInfo());
            //Console.WriteLine(B1.FuldDyreInfo());
        }
    }
}
