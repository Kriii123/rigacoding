using System;
using System.Collections.Generic;
using System.Linq;

namespace karatavas
{
    public class Karatavas
    {
        List<string> vardi;

        string minamaisVards;

        char[] atminetaisVards;

        int dzivibas;

        public Karatavas()
        {
            vardi = new List<string>()
            {
                "ĀBOLS",
                "BUMBIERIS",
                "ARBŪZS",
            };
        }
        public void JaunaSpele()
        {
            dzivibas = 5;
            vardi = vardi.OrderBy(vardi => Guid.NewGuid()).ToList();
            minamaisVards = vardi[0];
            atminetaisVards = new char[minamaisVards.Length];
            for (int i = 0; i < minamaisVards.Length; i++)
            {
                atminetaisVards[i] = '_';
            }

        }
        public bool Minet(char burts)
        {
            burts = Char.ToUpper(burts);
            bool vaiIrVarda = false;
            for(int i = 0; i < minamaisVards.Length; i++)
            {
                if(minamaisVards[i] == burts)
                {
                    atminetaisVards[i] = burts;
                    vaiIrVarda = true;
                }
            }
            if(!vaiIrVarda)
            {
                dzivibas--;
            }
            return vaiIrVarda;
        }
        public int DzivibuSkaits()
        {}

        public bool VaiIrAtminets()
        {
            //1.variants
            return minamaisVards == new string(atminetaisVards);
            //2. variants
            //return !atminetaisVards.Contains('_');
        }

        public string AtminetaisVards()
        {
            //___ -> _ _ _ _
            return String.Join(" ", atminetaisVards);

        }
    }
}
