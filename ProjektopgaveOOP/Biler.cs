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
        public string modelÅrgang { get; set; }
        public string Kilometer { get; set; }
        public string Brændstof { get; set; }
        public string Interior { get; set; }

        //default constructor
        public Biler(string opretDato, string Nummerplade, string Mærke, string modelÅrgang) : base(opretDato)
        {
            this.regNr = Nummerplade;
        }

        public Biler(string Mærke)
        {
            this.Mærke = Mærke;
        }

        public Biler(string modelÅrgang, string Mærke)
        {
            this.modelÅrgang = modelÅrgang;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        public override string KundeInformation()
        {
            return base.KundeInformation() + (" " + regNr + " " + Oprettelsesdato + " ");
        }
    }
}
