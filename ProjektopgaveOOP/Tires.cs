using System;
namespace ProjektopgaveOOP
{
    public class Tires:Biler
    {
        public string Brand { get; set; }
        public string tireSize { get; set; }
        public string tireType { get; set; }

        //default constructor
        public Tires(string opretDato, string flereBiler, string tireBrand) : base(opretDato)
        {
            this.Brand = tireBrand;
        }

        public Tires(string Size)
        {
            this.tireSize = Size;
        }

        public Biler(string bilEjerTypeP, string opretDato, string flereBiler)
        {
            this.Privat = bilEjerTypeP;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        public override string KundeInformation()
        {
            return base.KundeInformation() + (" " + Brand + " " + Oprettelsesdato + " ");
        }
    }
}
