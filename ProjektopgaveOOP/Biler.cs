using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektopgaveOOP
{
    public class Biler:Værksted
    {
        public string regNr { get; set; }
        public string Mærke { get; set; }
        public int modelÅrgang { get; set; }
        public int Kilometer { get; set; }
        public string Fuel { get; set; }
        public string Color { get; set; }

        //default constructor
        public Biler(string opretDato, string Nummerplade, string Brand, int Year, int KM, string Fuel, string Color) : base(opretDato)
        {
            this.regNr = Nummerplade;
            this.Mærke = Brand;
            this.modelÅrgang = Year;
            this.Kilometer = KM;
            this.Fuel = Fuel;
            this.Color = Color;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        //public override string KundeInformation()
        //{
        //    return base.KundeInformation() + ();
        //}
    }
}
