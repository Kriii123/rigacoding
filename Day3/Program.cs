using System;

namespace Day3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Taisnsturis t1 = new Taisnsturis(4, 34);
            Taisnsturis t2 = new Taisnsturis(42, 9);
            t1.Laukums();
            t2.Laukums();*/

            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Vards = "Pēteris";
            darbinieks.Uzvards = "Zaļais";
            darbinieks.DzGads = 1985;
            darbinieks.Epasts = "pz@inbox.lv";

            Adrese adrese = new Adrese();
            adrese.Valsts = "Latvijā";
            adrese.Pilseta = "Liepājā";
            adrese.Iela = "Duntes ielā";
            adrese.MajasNr = "3B-";
            adrese.DzivoklaNr = 4;
            darbinieks.Dzivesvieta = adrese;

            darbinieks.AktualaNodala = new Nodala();
            darbinieks.AktualaNodala.Nosaukums = "Ozolu nodaļu";
            darbinieks.AktualaNodala.AtrasanasVieta = new Adrese();

            darbinieks.IeprieksajaNodala = new Nodala();
            darbinieks.IeprieksajaNodala.Nosaukums = "Bērzu nodaļas";
            darbinieks.IeprieksajaNodala.AtrasanasVieta = new Adrese();
            darbinieks.IeprieksajaNodala.AtrasanasVieta.Valsts = "Latvijā";
            darbinieks.IeprieksajaNodala.AtrasanasVieta.Pilseta = "Valmierā";
            darbinieks.IeprieksajaNodala.AtrasanasVieta.Iela = "Burkānu ielā";
            darbinieks.IeprieksajaNodala.AtrasanasVieta.MajasNr = "12-";
            darbinieks.IeprieksajaNodala.AtrasanasVieta.DzivoklaNr = 4;

            darbinieks.TeikumsViens();
            darbinieks.TeikumsDivi();
            darbinieks.Teikums3();
            darbinieks.Teikums4();

            Console.ReadLine();
        }
    }
}
