// V Your code goes below V
// initializeer de variables die uiteindelijk in de PrintFortune functie komen.
int iChosenNumber = 0;
int fortuneNumber = 0;
int iChosenColourLength = 0;

// twee lijstjes met de correcte strings en ints voor de twee vragen deze
// worden gebruikt om te checken of het antwoord correct is.
List<string> colours = new List<string>() {"red", "blue", "green", "yellow"};
List<int> numberRange = new List<int>() {1,2,3,4,5,6,7,8};

// om bij te houden welke antwoorden goed zijn
bool bCorrectAnswer = false;
bool bColourCorrect = false;

while (bCorrectAnswer == false)
{
    // als de kleur eerder correct is ingevuld kan je het overslaan
    if (bColourCorrect != true)
    {
        // vraag naar de kleuren en lees de gebruikers input
        Console.Write("Pick a color (red/blue/green/yellow):\n>");
        string chosenColour = Console.ReadLine();
        // check of je weer opnieuw moet als de kleur niet in het
        // lijstje voor komt
        if (!colours.Contains(chosenColour))
        {
            bCorrectAnswer = false;
            continue;
        }
        iChosenColourLength = chosenColour.Length;
    }
    // als er niet in de if gekomen is mag je het nu altijd overslaan
    bColourCorrect = true;

    // vraag om een getal
    Console.Write("Pick a number (1-8):\n>");
    iChosenNumber = Convert.ToInt16(Console.ReadLine());
    // check ook of deze klopt en anders kan je de vraag weer opnieuw stellen
    if (!numberRange.Contains(iChosenNumber))
    {
        bCorrectAnswer = false;
        continue;
    }

    // alle antwoorden zijn correct nu mag je de loop verlaten
    bCorrectAnswer = true;
}

// zet de fortunenumber naar de gekozen nummer
fortuneNumber = ((iChosenNumber + iChosenColourLength) % 4) + 1;

// ^ Your code goes above ^
//No need to look below here for this assignment. But you are welcome to!
PrintFortune(fortuneNumber);

static void PrintFortune(int fortuneNumber)
{
    string fortune = fortuneNumber switch
    {
        1 => "You will be loved and be happy!",
        2 => "You will be loved and be rich!",
        3 => "You will be loved and be famous!",
        4 => "You will be loved, and you'll be happy, rich and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
    Console.WriteLine(fortune);
}