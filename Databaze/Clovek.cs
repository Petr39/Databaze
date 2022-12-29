namespace Databaze
{
    public class Clovek
    {
        /// <summary>
        /// Jméno a příjmení osoby
        /// </summary>
        private string Jmeno { get; set; }
        /// <summary>
        /// Věk osoby
        /// </summary>
        private int Vek { get; set; }
        /// <summary>
        /// Vlastnost plnoletosti, když je víc jak 18 let
        /// </summary>
        private bool Plnolety => Vek >= 18;
        /// <summary>
        /// Vlastnost o úmrtí
        /// </summary>
        private bool Mrtev => Vek > 100;
        /// <summary>
        /// Vlastnost privátní zprávy o plnoletosti ve stringu
        /// </summary>
        private string zprava;
        /// <summary>
        /// Zatím nic nedělá
        /// </summary>
        public int Poradi { get; private set; }
       
        /// <summary>
        /// Aktuální datum při vložení osoby
        /// </summary>
        private DateTime Datum;
        private SeznamLidi seznamZkouska=new SeznamLidi();  

        public Clovek(string jmeno, int vek, DateTime datum)
        {
            Jmeno = jmeno;
            Vek = vek;
            Datum = datum;
           
        }
        /// <summary>
        /// Vrátí text, jestli člověk je plnoletý/á
        /// </summary>
        /// <returns></returns>
        public string JePlnoletyANaZivu()
        {
            zprava = "";
            if (Plnolety)
            {
                if (Mrtev) zprava = "už nežije";
                else zprava = "je plnoletý/á";
            }
            else zprava = "není plnoletý/á";
            return zprava;
        }
        /// <summary>
        /// Vrátí do stringu vlastnosti
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}  {1} ", Jmeno, Vek);
        }

        /// <summary>
        /// Vypsání osoby v seznamu databáze
        /// </summary>
        public void VypisOsobu()
        {            
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine("Jméno: {0}", Jmeno);
            Console.WriteLine("Věk: {0}", Vek);
            Console.WriteLine("{0}", JePlnoletyANaZivu());
            Console.WriteLine("Osoba vložena: {0}", (Datum.Year,Datum.Month,Datum.Day));            
            Console.ResetColor();
        }        
        //Zatím nic nedělá - tato třída je v procesu a je zapečetěná
         sealed private class Obleceni
        {
            private string OblibenaBarva { get; set; }
            private int CisloBot { get; set; } 
            
            private enum Barva
            {
                Červená=1,Bílá=2,Modrá=4,Hnědá=8,Zelená=16
            }
        }
    }
}
