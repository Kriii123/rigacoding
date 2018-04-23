using System;
namespace Day3
{
    public class Darbinieks
    {
        
        public string Vards;
        public string Uzvards;
        public int DzGads;
        public string Epasts;
        public string Talrunis;
        public Nodala AktualaNodala;
        public Nodala IeprieksajaNodala;
        public Adrese Dzivesvieta;
        public void TeikumsViens() 

        {
            Console.WriteLine("Mani sauc " + Vards + ", es dzīvoju " + Dzivesvieta.PilnaAdrese());
        }
        public void TeikumsDivi()
        {
            Console.WriteLine("Mani sauc " + Vards + " un es pārgāju uz " + AktualaNodala.Nosaukums + " no "
                              + IeprieksajaNodala.Nosaukums 
                              + ", kura atradās" + IeprieksajaNodala.AtrasanasVieta.PilnaAdrese());  
        }
        public void Teikums3()
        {
            Console.WriteLine("Mans epasts tālākai saziņai: " + Epasts);
        }
        public void Teikums4()
        {
            Console.WriteLine("Esmu dzimis " + DzGads + ". gadā un iepriekš dzīvoju "
                              + IeprieksajaNodala.AtrasanasVieta.PilnaAdrese());
            
        }
    }
}
