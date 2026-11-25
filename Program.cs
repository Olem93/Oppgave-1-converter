Console.WriteLine("Velg hva du vil konvertere");
// Temperatur: Celsius, fahrenheit
Console.WriteLine("  1. Temperatur");
Console.WriteLine("  2. Valuta");
Console.WriteLine("  3. Vekt");
var choice = ChooseType();
Console.Clear();
var tempTest = CheckType(choice);
Console.WriteLine(tempTest);
static string CheckType(string choice)
{
    if (choice == "Temperatur")
    {
        Console.WriteLine("Velg hvilket temperaturformat du vil konvertere til");
        Console.WriteLine("  1. Celsius til Fahrenheit");
        Console.WriteLine("  2. Fahrenheit til Celsius");
        return TempConverter();
    }
    return "";
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

//0 C = 30 F
//0 F = -17.7778/18 C
static void TempValues()
{
    var input = Console.ReadLine();
    try
    {
        int.Parse(input);
    }

}


















//Oppgave 1 - Converter
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere, 
//velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.