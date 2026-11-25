
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
    GoToValueConverter(choice, choiceSub);

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
        return TempConverter();
    }
    else if (choice == "Valuta")
    {
        Console.WriteLine("Velg hvilket vektformat du vil konvertere til");
        Console.WriteLine("  1. nok til dollar");
        Console.WriteLine("  2. dollar til nok");
        return CurrencyConverter();
    }
    else if (choice == "Vekt")
    {
        Console.WriteLine("Velg hvilket vektformat du vil konvertere til");
        Console.WriteLine("  1. kg til lb");
        Console.WriteLine("  2. lb til kg");
        return WeightConverter();
    }
        
    return "";
}

static void GoToValueConverter(string choice, string choiceSub)
{
    if (choice == "Temperatur")
    {
        TempValues(choiceSub); //Sender spesifikasjoner til metode som gjør matte
    }
    else if (choice == "Valuta")
    {
        CurrencyValues(choiceSub);
    }
    else if (choice == "Vekt")
    {
        WeightValues(choiceSub);
    }
}

static string WeightConverter()
{
    var input = Console.ReadLine();
    var choice = input switch
    {
        "1" => "kg til lb",
        "2" => "lb til kg",
        _ => "",
    };
    return choice;
}

static string CurrencyConverter()
{
    var input = Console.ReadLine();
    var choice = input switch
    {
        "1" => "nok til dollar",
        "2" => "dollar til nok",
        _ => "",
    };
    return choice;
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
            Console.WriteLine($"  \n{inputNum}C er {(inputNum * 1.8) + 32:F1}F");
        }
        else if (choiceSub == "Fahrenheit til Celsius")
        {
            Console.WriteLine($"  \n{inputNum}F er {(inputNum - 32) / 1.8:F1}C");
        }
        Restart();
    } 
    catch (Exception)
    {
        Console.WriteLine("Skriv et tall");
        TempValues(choiceSub);
    }
}

static void CurrencyValues(string choiceSub)
{
    Console.WriteLine("Skriv tallet du vil konvertere");
    var input = Console.ReadLine();
    try
    {
        int inputNum = int.Parse(input);
        if (choiceSub == "nok til dollar")
        {
            Console.WriteLine($"  \n{inputNum} nok er {inputNum * 0.1} dollar");
        }
        else if (choiceSub == "dollar til nok")
        {
            Console.WriteLine($"  \n{inputNum} dollar er {inputNum * 10} nok");
        }
        Restart();
    }
    catch (Exception)
    {
        Console.WriteLine("Skriv et tall");
        TempValues(choiceSub);
    }
}

static void WeightValues(string choiceSub)
{
    Console.WriteLine("Skriv tallet du vil konvertere");
    var input = Console.ReadLine();
    try
    {
        int inputNum = int.Parse(input);
        if (choiceSub == "kg til lb")
        {
            Console.WriteLine($"  \n{inputNum}kg er {(inputNum * 2.20462):F1}lb");
        }
        else if (choiceSub == "lb til kg")
        {
            Console.WriteLine($"  \n{inputNum}lb er {(inputNum / 2.20462):F1}kg");
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