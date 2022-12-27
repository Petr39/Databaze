using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaze
{
    public class SeznamLidi
    {

        /// <summary>
        /// Instance lidí, kteří se přidají
        /// </summary>
        private List<Clovek> lide;
        /// <summary>
        /// Instance pro přidání dat do osoby
        /// </summary>
        private Clovek clovek;
        /// <summary>
        /// Statický parametr pro přidání pořadového čísla zaměstnance
        /// </summary>
        private static int Id; 

        /// <summary>
        /// KOnstruktor s instancí Listu lide
        /// </summary>
        public SeznamLidi()
        {
            lide= new List<Clovek>();
        }
        /// <summary>
        /// Přidání osoby do databáze
        /// </summary>
        public void PridatOsobu()
        {       
            DateTime datum= DateTime.Now;
            Console.Write("Zadej jméno: ");
            string jmeno=Console.ReadLine();
            Console.Write("Zadej věk: ");
            int vek;
            while(!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Zadej prosím věk v číselné podobě");
            clovek= new Clovek(jmeno,vek,datum);
            lide.Add(clovek);
            Console.WriteLine("Osoba byla předána do databáze");
        }
        /// <summary>
        /// Vypsání osob ze seznamu
        /// </summary>
        public void VypisOsoby()
        {
            foreach (var item in lide)
            {
                Console.WriteLine(item);
                //clovek.VypisOsobu();
                Console.WriteLine(VypisPomlcky());
            }
        }
        /// <summary>
        /// Vypíše pomlčky do linky pod text
        /// </summary>
        /// <returns></returns>
        public string VypisPomlcky()
        {
            string s = "-";
            for (int i = 0; i < 80; i++)
            {
                s += "-";
            }
            return s;
        }
    }
}
