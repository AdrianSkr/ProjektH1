using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace ProjektopgaveOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Kunder> kundeListe = new List<Kunder>();
            kundeList nyKunde = new kundeList();

            string mydocpath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Console.WriteLine("*** VÆRKSTED FOR MEMERS ***");

            Console.WriteLine("Hvad vil du? (dit svar, efterfulgt af 'enter'");
            Console.WriteLine("Se en fuld kundeliste, tryk: K ");
            Console.WriteLine("Tilføje en kunde til registret, tryk: T ");
            Console.WriteLine("Slette en kunde fra registret, tryk: S");
            string kundeHandling = Console.ReadLine().ToLower();

            if(kundeHandling=="K")
            {
                Console.WriteLine("*** KUNDE LISTE ***");
                Console.WriteLine("Udksriver til fil: Kundeliste.txt");

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt")))
                {
                    outputFile.WriteLine("***KVITTERING***");
                    foreach (Vare nyvare in minvareliste)
                    {
                        outputFile.WriteLine();
                        outputFile.WriteLine("Du har handlet: " + nyvare.vareAntal + " stk. " + nyvare.vareNavn + ". Til en pris af: " + nyvare.varePris + " kr. pr. stk.");
                        outputFile.WriteLine("Pris for alle: " + (nyvare.vareAntal * nyvare.varePris) + ".");
                    }


            }




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
