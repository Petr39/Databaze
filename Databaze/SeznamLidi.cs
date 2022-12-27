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
        /// Konstruktor s instancí Listu lide
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
            int UnikatniId;
            IdOsoby = Id;
            UnikatniId = IdOsoby;
            clovek = new Clovek(jmeno, vek, datum, UnikatniId);
            if (clovek != null)
            {
                lide.Add(clovek);
                Id++;
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
                Console.WriteLine(VypisPomlcky());
            }

            Console.WriteLine("Zadej ID osoby se pro víc infomrací....");
            int IdOsoby = int.Parse(Console.ReadLine());
            NajdiOsobu(IdOsoby);
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

        /// <summary>
        /// Vypíše osoby podle zadaného ID
        /// </summary>
        /// <param name="cislo"></param>
        public void NajdiOsobu(int cislo)
        {         
            var osoba = lide.Where(a => a.Poradi == cislo);
            foreach (var item in osoba)
            {                
               item.VypisOsobu();
                
            }
        }
    }
}
