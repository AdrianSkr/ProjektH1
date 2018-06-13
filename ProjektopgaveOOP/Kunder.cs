using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ProjektopgaveOOP
{
    public class Kunder
    {
        public string Biler { get; set; }
        public string Erhvev { get; set; }
        public string Privat { get; set; }

        //default constructor
        public Kunder(string opretDato, string flereBiler) : base(opretDato)
        {
            this.Biler = flereBiler;
        }

        public Kunder(string bilEjerTypeE)
        {
            this.Erhvev = bilEjerTypeE;
        }

        public Kunder(string bilEjerTypeP, string opretDato, string flereBiler)
        {
            this.Privat = bilEjerTypeP;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        public override string KundeInformation()
        {
            return base.KundeInformation() + (" " + Biler + " " + Oprettelsesdato + " ");
        }
    }
}
