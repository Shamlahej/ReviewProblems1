// Opgaven går ud på at tage et helt tal fra brugeren
// og lægge alle cifrene sammen. 
// Vi læser et tal fra brugeren (som string)
var userInput = Console.ReadLine();

// Vi prøver at lave teksten om til et heltal (integrar)
int.TryParse(userInput, out var number);

// Her gemmer vi den samlede sum af cifrene
int sum = 0;

// While-løkken kører så længe der stadig er noget tal tilbage
while (number > 0)
{
    // Modulo 10 giver det sidste ciffer i tallet
    int remainder = number % 10;

    // Vi lægger det sidste ciffer til summen
    sum = sum + remainder;

    // Vi fjerner det sidste ciffer ved at dele tallet med 10
    number /= 10;
}

// Til sidst viser vi summen af alle cifrene
Console.WriteLine(sum);
