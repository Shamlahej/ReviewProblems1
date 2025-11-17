// Opgaven handler om, at du ikke helt ved, om du skal tage til undervisning.
// programmet skal hjælpe dig med at tage beslutning. 
// Kriterierne er: at forelæsningen er interessant. Mindst en af dine venner kommer til forelæsning. Du har problemer med afleveringen. 
// Vi starter med at spørge brugeren om selve forelæsningen er interessant.
Console.WriteLine("Is the lecture interesting?");

// Console.ReadLine venter på, at brugeren skriver et svar.
// Svarene er typisk “y” for yes eller noget andet for no.
var line = Console.ReadLine();

// Vi laver en boolean-variabel, som skal fortælle om forelæsningen er spændende.

bool isLectureInteresting = true;

// Hvis brugeren skrev “y”, så siger vi at forelæsningen ER interessant.
// Hvis brugeren ikke skrev “y”, så lader vi variablen være. 
if (line == "y")
{
    isLectureInteresting = true;
}

// Her laver vi to flere boolean-variabler.
// De er sat til true.

bool myFriendsJoins = true;
bool haveProblemsWithTheAssignment = true;

// Nu laver vi selve beslutningen.
// Reglen er: Du går til forelæsningen hvis den er interessant OG enten dine venner kommer med ELLER du har problemer med opgaven.
// “&&” betyder at begge ting skal være sande.
// “||” betyder at mindst én af tingene skal være sand
if (isLectureInteresting && (myFriendsJoins || haveProblemsWithTheAssignment))
    Console.WriteLine("Go from class");
else 
    Console.WriteLine("Stay in class");