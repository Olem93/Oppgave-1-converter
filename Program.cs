
Run();

static void Run()
{
    Console.WriteLine("Velg hva du vil konvertere");

    Console.WriteLine("  1. Temperatur");
    Console.WriteLine("  2. Valuta");
    Console.WriteLine("  3. Vekt");
    var choice = ChooseType(); //Svare på meny over
    Console.Clear(); //Tømmer konsollen
    var choiceSub = CheckType(choice); //Sender tall til metode og returnerer spesifikasjoner
    Console.Clear();
    TempValues(choiceSub); //Sender spesifikasjoner til metode som gjør matte
}


static string ChooseType()
{
    var input = Console.ReadLine();
    var choice = input switch
    {
        "1" => "Temperatur",
        "2" => "Valuta",
        "3" => "Vekt",
        _ => "",
    };
    return choice;
}

static string CheckType(string choice)
{
    if (choice == "Temperatur")
    {
        Console.WriteLine("Velg hvilket temperaturformat du vil konvertere til");
        Console.WriteLine("  1. Celsius til Fahrenheit");
        Console.WriteLine("  2. Fahrenheit til Celsius");
        return TempConverter(); //returnerer spesifikasjoner til "hovedkoden"
    }
    return "";
}


static string TempConverter()
{
    var input = Console.ReadLine();
    var choice = input switch
    {
        "1" => "Celsius til Fahrenheit",
        "2" => "Fahrenheit til Celsius",
        _ => "",
    };
    return choice;
}

static void TempValues(string choiceSub)
{
    Console.WriteLine("Skriv tallet du vil konvertere");
    var input = Console.ReadLine();
    try
    {
        int inputNum = int.Parse(input);
        if (choiceSub == "Celsius til Fahrenheit")
        {
            Console.WriteLine($"  \n{inputNum}C er {(inputNum * 1.8) + 32}F");
        }

        Restart();


    } 
    catch (Exception)
    {
        Console.WriteLine("Skriv et tall");
        TempValues(choiceSub);
    }

}


static void Restart()
{
    Console.WriteLine("\nTrykk på en tast for å starte på nytt");
    Console.ReadKey();
    Console.Clear();
    Run();
}

















//Oppgave 1 - Converter
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere, 
//velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.