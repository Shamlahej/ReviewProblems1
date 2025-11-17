// Opgaven går ud på at finde ud af, om det første tal kan deles helt med det andet.
// Vi bruger modulus-operatoren (%)

namespace MultiplesOfNumbers;

class Program
{
    static void Main(string[] args)
    {
        // Vi beder brugeren skrive det første tal.
        // Det her tal er det, der skal "deles".
        
        Console.WriteLine("Enter dividend");
        string userinput1 = Console.ReadLine();

        // Her spørger vi efter det tal, der skal deles med.
        
        Console.WriteLine("Enter your dividor");
        string userinput2 = Console.ReadLine();
        
        // Brugeren har skrevet teksten som string, men vi skal bruge rigtige tal.
        // TryParse lave teksten om til et heltal.
        
        int.TryParse(userinput1, out var number1);
        int.TryParse(userinput2, out var number2);
        
        // Nu tjekker vi om det første tal går op i det andet.
        // Modulus (%) giver os resten efter divideret.
        // Hvis resten er 0, betyder det at det går op uden problemer.
        if (number1 % number2 == 0)
            Console.WriteLine("Multiples possible");
        else if (number1 % number2 != 0)
            Console.WriteLine("Multiples not possible");
    }
}
