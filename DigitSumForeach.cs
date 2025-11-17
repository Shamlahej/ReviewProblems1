// Opgaven handler om at tage et helt tal fra brugeren,
// kigge på hver enkelt digit (altså hvert enkelt tegn i tallet),
// lave dem om til rigtige tal og lægge dem sammen.

namespace DigitSumForeach;

class Program
{
    static void Main(string[] args)
    {
        // Først beder vi brugeren om at skrive et tal.
        // Det de skriver, bliver læst som tekst, ikke som et rigtigt tal.
        var userInput = Console.ReadLine();
        
        // Her laver vi en variabel, der starter på 0.
        // Den skal bruges til at lægge alle sammen.
        int sum = 0;
        
        // Nu vil vi kigge på tallet ét tegn ad gangen.
        // Et foreach-loop går igennem hver karakter, character i den tekst, brugeren skrev.
        // Hvis brugeren skruver "1234", så ser loopen først '1', så '2', så '3' osv.
        foreach (var c in userInput)
        {
            // Hvert tegn er stadig bare et tegn (char), ikke et tal.
            // Derfor laver vi tegnet om til en string først (c.ToString()),
            // og derefter laver vi den string om til et helt tal med Convert.ToInt32.
            //
            // Når vi har tallet, lægger vi det til vores sum-variabel.
            sum = sum + Convert.ToInt32(c.ToString());

            // Dette kunne også skrives kortere som:
            // sum += Convert.ToInt32(c.ToString());
        }

        // Til sidst viser vi summen af alle cifrene i tallet.
        Console.WriteLine(sum);
    }
}
