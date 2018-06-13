using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ProjektopgaveOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog D1 = new Dog("Bigdog", "12", "Brazil");
            Cat C1 = new Cat("Tigermancat", "42", "Norway'nt", "Meooooooooow");
            Fish F1 = new Fish("Sea Linguini", "124", "Sealand");
            Bird B1 = new Bird("Eaglebird", "4", "Afrika'nt", "Pipipipipipipipipip");

            Console.WriteLine(D1.FuldDyreInfo());
            Console.WriteLine(C1.FuldDyreInfo());
            Console.WriteLine(F1.FuldDyreInfo());
            Console.WriteLine(B1.FuldDyreInfo());
        }
    }
}
