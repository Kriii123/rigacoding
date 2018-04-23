using System;
namespace day1_klases
{
    public class ManaPirmaKlase
    {
        /// <summary>
        /// Funkcija bez rezultāta 
        /// un bez ievadparametriem
        /// </summary>
        public void SayHello (){
            Console.WriteLine("Hello!");
            Console.WriteLine("viss sanāk!");
        }

        /// <summary>
        /// Funkcija ar rezultātu 
        /// un bez ievadparametriem
        /// </summary>
        /// <returns>The number.</returns>
        public int GetNumber(){
            return 99;
        }
        /// <summary>
        /// Funkcija ar rezultātu
        /// un ar ievadparametriem       
        /// </summary>
        /// <returns>The number2.</returns>
        /// <param name="skaitlis">Skaitlis.</param>
        public int GetNumber2(int skaitlis){
            return skaitlis;
        }
    }
}
