using Databaze;

SeznamLidi seznam = new SeznamLidi();
Console.WriteLine("Vítej, zde můžeš přidávat lidi do databáze");
bool pokracovat = true;
Console.WriteLine("");
Console.ReadLine();
while (pokracovat)
{
    Console.Clear();
    Console.WriteLine("Zadej volbu");
    Console.WriteLine("1 - Přidat osobu");
    Console.WriteLine("2 - Vypsat osoby");
    Console.WriteLine("3 - Konec");

    string volba = Console.ReadLine();
    switch (volba)
    {
        
        case "1":            
            seznam.PridatOsobu();
            break;
        case "2":
            Console.Clear();
            seznam.VypisOsoby();
            Console.WriteLine("Pro pokračování stiskni Enter");
            break;
        case "3":
            Console.WriteLine("Díky za použití aplikace");
            pokracovat = false;
            break;
        default:
            Console.WriteLine("Špatně zadaná volba, zadej znovu ve tvaru čísla ");
            break;
    }
    Console.ReadLine();
}





