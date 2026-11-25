Console.WriteLine("Velg hva du vil konvertere");
// Temperatur: Celsius, fahrenheit, kelvin
Console.WriteLine("  1. Valuta");
Console.WriteLine("  2. Temperatur");
Console.WriteLine("  3. Vekt");
var choice = chooseType();
Console.WriteLine(choice);

static string chooseType()
{
    var input = Console.ReadLine();
    var choice = input switch
    {
        "1" => "Valuta",
        "2" => "Temperatur",
        "3" => "Vekt",
        _ => "",
    };
    return choice;
}


















//Oppgave 1 - Converter
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere, 
//velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.