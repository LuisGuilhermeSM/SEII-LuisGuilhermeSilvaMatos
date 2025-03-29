string aquariumStoreInventory = "tartaruga";

if(aquariumStoreInventory == "tartaruga"){
    Console.WriteLine("Vou comprar a tartaruga");
} else if(aquariumStoreInventory == "jabuti"){
    Console.WriteLine("Vou comprar a jabuti");
} else{
    Console.WriteLine("Vo comprar é nada");
}

aquariumStoreInventory = "peixe palhaço";

if(aquariumStoreInventory == "tartaruga" || aquariumStoreInventory == "jabuti" ){
    Console.WriteLine("Vou comprar a tartaruga");
} else{
    Console.WriteLine("Vo comprar é nada");
}


//<>
int fishTankPrice = 1000;

if(fishTankPrice <= 1000)
{
    Console.WriteLine("Buy tank");
}
else
{
    Console.WriteLine("Don't buy");
}

//Checar por tipo de variavel
string aquariumFish = "peixe espada";

if(aquariumFish is string){
    Console.WriteLine("Aquarium fish is a string");
}