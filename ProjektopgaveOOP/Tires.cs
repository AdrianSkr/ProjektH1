//using System;
//namespace ProjektopgaveOOP
//{
//    public class Tires:Biler
//    {
//        public string Brand { get; set; }
//        public string tireSize { get; set; }
//        public string tireType { get; set; }

//        //default constructor
//        public Tires(string opretDato, string flereBiler) : base(opretDato)
//        {
//            this.Brand = flereBiler;
//        }

//        public Biler(string bilEjerTypeE)
//        {
//            this.Erhvev = bilEjerTypeE;
//        }

//        public Biler(string bilEjerTypeP, string opretDato, string flereBiler)
//        {
//            this.Privat = bilEjerTypeP;
//        }

//        //Overrider virtual method in base class værksted, som hedder KundeInformation
//        public override string KundeInformation()
//        {
//            return base.KundeInformation() + (" " + Biler + " " + Oprettelsesdato + " ");
//        }
//    }
//}
