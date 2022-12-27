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



        private bool Mrtev => Vek > 100;
        /// <summary>
        /// Vlastnost privátní zprávy o plnoletosti ve stringu
        /// </summary>
        private string zprava;

         public int Poradi { get;private set; }


        /// <summary>
        /// Aktuální datum při vložení osoby
        /// </summary>
        private DateTime Datum;


        public Clovek(string jmeno, int vek, DateTime datum, int poradi)
        {
            Jmeno = jmeno;
            Vek = vek;
            Datum = datum;
            Poradi = poradi;
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
                if (Mrtev)zprava = " už nežije";
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
            return String.Format("ID:{0}  {1}  {2} roků a {3} - datum vložení: {4}",Poradi, Jmeno, Vek, JePlnoletyANaZivu(),Datum);
        }

        /// <summary>
        /// Vypsání osoby v seznamu databáze
        /// </summary>
        public void VypisOsobu()
        {
            Console.WriteLine("Jméno: {0}",Jmeno);
            Console.WriteLine("Věk: {0}",Vek);
            //Console.WriteLine("{0}",zprava);
            Console.WriteLine("Vloženo: {0}",Datum);
        }    

    }
}
