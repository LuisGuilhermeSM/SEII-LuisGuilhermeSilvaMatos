//Counter
for(int i = 1; i <= 10; i++ ){
    Console.WriteLine(i);
}

string[] favoriteFood = ["Parmegiana", "Estraganois", "Sushi"];

for(int i = 0; i < favoriteFood.Length; i++){
    Console.WriteLine(favoriteFood[i]);
}

foreach(var food in favoriteFood){
    Console.WriteLine(food);
}

//Linq
favoriteFood.ToList().ForEach(i => {
    Console.WriteLine("ForEach: " + i);
});  

Array.ForEach(favoriteFood, food => {
    Console.WriteLine("Array.ForEach: " + food);
});
