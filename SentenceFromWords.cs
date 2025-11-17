// Opgaven er at programmet skal samle ord, som brugeren skriver en ad gangen, og bygge en hel sætning ud af dem.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words of a sentence one by one including punctuation:");
        
        // Vi laver to variabler: 
        // 'word' til det ord brugeren lige har skrevet,
        // 'sentence' til at samle hele sætningen.
        string word = "";
        string sentence = "";

        // While-løkken kører indtil brugeren skriver et ord der ender på punktum.
        while (!word.EndsWith("."))
        {
            // Vi læser det næste ord
            word = Console.ReadLine();

            // Her bygger vi sætningen op. 
            // Vi tager det vi allerede har, plus det nye ord, plus et mellemrum.
            sentence = sentence + word + " ";
        }

        // Trim fjerner det ekstra mellemrum til sidst,
        // og så viser vi den færdige sætning.
        Console.WriteLine(sentence.Trim());
    }
}
