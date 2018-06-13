using System;
namespace ProjektopgaveOOP
{
    public class Tires:Værksted
    {
        public string Brand { get; set; }
        public string tireSize { get; set; }
        public string tireType { get; set; }

        //default constructor
        public Tires(string opretDato, string tireBrand, string Size, string Type) : base(opretDato)
        {
            this.Brand = tireBrand;
            this.tireType = Type;
            this.tireSize = Size;
        }

        //Overrider virtual method in base class værksted, som hedder KundeInformation
        public override string KundeInformation()
        {
            return base.KundeInformation() + (" " + Brand + " " + Oprettelsesdato + " ");
        }
    }
}
