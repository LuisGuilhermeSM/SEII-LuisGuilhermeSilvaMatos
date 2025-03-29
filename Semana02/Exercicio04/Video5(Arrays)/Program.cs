//Arrays em c# são coleção/lista de tamanho fixo e de apenas um tipo de dados
//Array CRUD

//Create
string[] Array1 = new string[3];
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

string[] Teste = ["", "", "",];

//Read
Console.WriteLine(favoriteRats);
foreach(var rat in favoriteRats){
    Console.WriteLine(rat);
}

//Update
favoriteRats[0] = "Fancy Rat";
foreach(var rat in favoriteRats){
    Console.WriteLine(rat);
}

// LINQ - "update array linq"
var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b")); //Filtrando o array favoriteRats e pegando apenas as strings que começam com b
foreach(var rat in newFavoriteRats){
    Console.WriteLine(rat);
}