
string preHistoricFish = "Cockerelitte";

switch (preHistoricFish)
{
    case "Heliobatis":
        Console.WriteLine("Heliobatis");
        break;
    case "Cockerelitte":
        Console.WriteLine("Cockerelitte");
        break;
    default:
        Console.WriteLine("Nothing Matches");
        break;
}


var result = preHistoricFish switch
{
    "Heliobatis" => "Helobatis",
    "Cockerelitte" => "Cockerelitte",
    _ => "No match",
};

Console.WriteLine("This is a " + result);