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
        private bool Plnolety => Vek > 18;
        /// <summary>
        /// Vlastnost privátní zprávy o plnoletosti ve stringu
        /// </summary>
        private string zprava;


        public Clovek(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }

        /// <summary>
        /// Vrátí text, jestli člověk je plnoletý/á
        /// </summary>
        /// <returns></returns>
        public string JePlnolety()
        {
            zprava = "";
            if (Plnolety)
                zprava = "je plnoletý/á";
            else
                zprava = "není plnoletý/á";
            return zprava;
        }
        /// <summary>
        /// Vrátí do stringu vlastnosti
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} má {1} roků a {2}", Jmeno, Vek, JePlnolety());
        }

        /// <summary>
        /// Vypsání osoby v seznamu databáze
        /// </summary>
        public void VypisOsobu()
        {
            Console.WriteLine("Jméno: {0}",Jmeno);
            Console.WriteLine("Věk: {0}",Vek);
            Console.WriteLine("{0}",zprava);
        }

    }
}
