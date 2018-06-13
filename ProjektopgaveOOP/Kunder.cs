using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektopgaveOOP
{
    public class Kunder : Værksted
    {
        public int Biler { get; set; }
        public string ejerType { get; set; }
        public int kundeID { get; set; }

        //default constructor
        public Kunder(int ID, string opretDato, int antalBiler, string ejerType) : base(opretDato)
        {
            this.Biler = antalBiler;
            this.ejerType = ejerType;
            this.kundeID = ID;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        public override string KundeInformation()
        {
            return base.KundeInformation() + (kundeID+"\t"+ejerType+"\t "+Biler+"\t"+Oprettelsesdato);
        }
    }
}
