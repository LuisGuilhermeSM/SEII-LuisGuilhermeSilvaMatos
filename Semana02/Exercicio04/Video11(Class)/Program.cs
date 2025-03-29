using ConsoleApp;

//CRUD

//CREAT
Rat wolfRat = new Rat();
Rat fancyRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 100;
wolfRat.IsRadioctive = false;

fancyRat.Name = "Fancy Rat";
fancyRat.Number = 1200;
fancyRat.IsRadioctive = false;

//READ
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

//UPDATE
wolfRat.Name = "WOLF RAT";
fancyRat.Name = "FANCY RAT";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

//DELETE
wolfRat.Name = "";
fancyRat.Name = "";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);