using System.Security.Cryptography.X509Certificates;

namespace Databaze
{
    public class SeznamLidi
    {
        /// <summary>
        /// Instance slovníku, kde s ebudou ukládat osoby a jejich ID 
        /// </summary>
        private Dictionary<int, Clovek> zkouska;
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
        /// <summary>
        /// Inikátní Id, které je přiřazeno jako Klíč ve slovníku Dictionary<Klíč,Clovek>
        /// </summary>
        private int IdOsoby;

        /// <summary>
        /// Konstruktor s instancí Listu lide
        /// </summary>
        public SeznamLidi()
        {
            lide = new List<Clovek>();
            zkouska = new Dictionary<int, Clovek>();
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

            UnikatniId = Id;
            clovek = new Clovek(jmeno, vek, datum);
            if (clovek != null)
            {
                    zkouska.Add(UnikatniId, clovek);
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
            foreach (var item in zkouska)
            {
                Console.WriteLine("ID: " + item.Key.ToString() + "  " + item.Value);
                item.ToString();
                Console.WriteLine(VypisPomlcky());
            }
        }
        /// <summary>
        /// Vypíše pomlčky do linky pod text
        /// </summary>
        /// <returns>string</returns>
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
        /// Smazání osoby ze seznamu
        /// </summary>
        public void SmazatOsobu()
        {
            VypisOsoby();
            Console.WriteLine("Zadej ID osoby pro smazánní...");
            int IdOsoby;
            while (!int.TryParse(Console.ReadLine(), out IdOsoby))
                Console.WriteLine("Zadej ID pro smazání prosím");
            //Validace, jestli je ID v seznamu
            if (zkouska.Keys.Contains(IdOsoby))
            {
                Console.WriteLine("Osoba smazána");
                zkouska.Remove(IdOsoby);
            }
            else
                Console.WriteLine("Osoba nenalezena");

        }
        /// <summary>
        /// Vypsání dat o osobě
        /// </summary>
        public void VypisDataOsoby()
        {
            foreach (var item in zkouska)
            {

                item.Value.VypisOsobu();

            }
        }
        /// <summary>
        /// Uložení osob do textového souboru
        /// </summary>
        public void UlozitSeznamDoSouboru()
        {
            using (StreamWriter sw = new StreamWriter("textak.txt"))
            {
                foreach (var item in zkouska)
                {
                    sw.WriteLine("ID: "+item.Key.ToString()+" " + item.Value);
                }
                sw.Flush();
            }
            Console.WriteLine("Uloženo!");
        }
    }
}
