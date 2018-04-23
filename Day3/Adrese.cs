using System;
namespace Day3
{
    public class Adrese
    {
        public string Valsts;
        public string Pilseta;
        public string Iela;
        public string MajasNr;
        public int DzivoklaNr;
        public string PilnaAdrese()
        {
            string adrese = Valsts + ", " + Pilseta + ", " + Iela + " " + MajasNr + DzivoklaNr;

            return adrese;

        }

    }
}
