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
            Console.Write("Antal biler ");
            int antalBiler = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ejer type ");
            string ejerType =Console.ReadLine();

            Kunder Kunde1001 = new Kunder(1001, "12/12-2010", antalBiler, ejerType);
            Kunder Kunde1002 = new Kunder(1002, "01/10-2010", antalBiler, ejerType);

            Console.WriteLine(Kunde1001.KundeInformation());
            Console.WriteLine(Kunde1002.KundeInformation());

        }
    }
}
