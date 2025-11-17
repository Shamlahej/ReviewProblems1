// Opgaven siger: læs to heltal fra brugeren og vis forskellige regnestykker.
// Derfor skal vi først spørge brugeren om to tal, og bagefter regne på dem.

using System;

class Program
{
    static void Main(string[] args)
    { 
        // Først beder vi brugeren om at skrive et tal. Console.WriteLine viser teksten på skærmen.
        Console.WriteLine("Enter your integer 1");
        // Console.ReadLine læser præcis det brugeren skriver, men det bliver altid læst som tekst (string).
        string userinput1 = Console.ReadLine();

        // Vi gør det samme igen for tal nummer 2.
        Console.WriteLine("Enter your integer 2");
        string userinput2 = Console.ReadLine();
        
        // Nu har vi to stykker string, men vi kan ikke regne med string, vi har istedet brug for integar.
        // TryParse forsøger at lave teksten om til et rigtigt heltal.
        // så er output at bliver tallet gemt i number1 og number2.
        int.TryParse(userinput1, out var number1);
        int.TryParse(userinput2, out var number2);
        
        // Så bruger vi bare tallene som almindelige heltal.
        // Console.WriteLine viser resultatet af hver beregning på skærmen.

        // vi lægger de to tal sammen.
        Console.WriteLine(number1 + number2);

        // vi trækker det andet tal fra det første.
        Console.WriteLine(number1 - number2);

        // vi ganger de to tal.
        Console.WriteLine(number1 * number2);

        // vi divedere det første tal med det andet.
        // Vi regner med heltal, så der kommer ikke decimaler.
        Console.WriteLine(number1 / number2);

        // vi laver modulus.
        Console.WriteLine(number1 % number2);
    }
}