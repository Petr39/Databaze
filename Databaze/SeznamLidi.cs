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
        private static int Id = 1;

        private int IdOsoby;

        /// <summary>
        /// KOnstruktor s instancí Listu lide
        /// </summary>
        public SeznamLidi()
        {
            lide = new List<Clovek>();

        }
        /// <summary>
        /// Přidání osoby do databáze
        /// </summary>
        public void PridatOsobu()
        {
            DateTime datum = DateTime.Now;
            Console.Write("Zadej jméno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadej věk: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Zadej prosím věk v číselné podobě");
            IdOsoby = Id;
            Id++;
            clovek = new Clovek(jmeno, vek, datum, IdOsoby);
            if (clovek != null)
            {
                lide.Add(clovek);
            //Console.WriteLine(UkladamData());
            Console.WriteLine("Osoba byla přidána do databáze");
            }
            else
            {
                Console.WriteLine("Chyba v ukládání");
            }
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
        /// <summary>
        /// Simulace ukládání dat 
        /// </summary>
        /// <returns></returns>
        public string UkladamData()
        {
            Console.Write("Ukládám");
            string s = ".";
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(400);
                Console.Write(s);
            }
            return s;
        }
    }
}
