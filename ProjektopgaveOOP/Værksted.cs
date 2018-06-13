using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektopgaveOOP
{
    public class Værksted
    {
        public string Oprettelsesdato { get; set; }

        //Default constructor
        public Værksted()
        {
        }

        public Værksted(string opretDato)
        {
            this.Oprettelsesdato = opretDato;
        }

        //Metode der kan overrides i nedarvede classer -- denne overrider vores kunder eller Biler class
        public virtual string KundeInformation()
        {
            return "";
        }
    }
}
