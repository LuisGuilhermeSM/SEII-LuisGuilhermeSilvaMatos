using System.Text; // Para importar o namespace StringBuilder

string petFish = "puffer fish";


//Concatenation
petFish = "porcupine " + petFish;

Console.WriteLine(petFish);


//Template Literal
//Adicionando/formatando uma string com o valor de outra variavel
Console.WriteLine($"I am buying {petFish}.");

int num = 2;
Console.WriteLine($"Numero: {num}");

//READ
//Console.WriteLine()

//UPDATE
//petFish[0] = "P";
string newPetFish = petFish.Replace("Porcupine", "blue dot");
Console.WriteLine(newPetFish);

//DELETE
//String Builder usa esse tipo pois o tipo string em c# é imutável
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);
newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);