//public record Person(string FirstName, string LastName, string[] PhoneNumbers); // Ele dá erro se for inicializado no início
//error CS8803: As instruções de nível superior precisam preceder as declarações de namespace e de tipo.

Person person1 = new Person("Teddy", "Smith", new string[1] { "555-1234"});
Person person2 = new Person("Teddy", "Smith", new string[1] { "555-1234"});

PersonWithoutNumber person3 = new PersonWithoutNumber("Teddy", "Smith");
PersonWithoutNumber person4 = new PersonWithoutNumber("Teddy", "Smith");

//Shallow Immutability
//person1.LastName = "smith";  //Essa mudança dá erro, não é possível faze-la
//error CS8852: A propriedade somente de inicialização ou o indexador 'Person.LastName' 
//só pode ser atribuído em um inicializador de objeto, em 'this' ou 'base' em um construtor de instância ou em um acessador 'init'.

person1.PhoneNumbers[0] = "222-2222";  //Essa dá certo

//Imutabilidade superficial (Shallow immutability):
//Após a inicialização, você não pode alterar o valor das propriedades do tipo valor ou a referência de propriedades de tipo de referência.
//No entanto, os dados aos quais uma propriedade de tipo de referência se refere podem ser alterados

//Equality
//Records são comparados com base em:
//Value type - 1. check the type 2. Check the contents
//Referential type - 1. By memory (hex code); checa se o endereço de memoria de armazenamento é o mesmo
Console.WriteLine(person1 == person2);
//Deu False pois os arrays estão armazenados em endereços diferentes de memoria

Console.WriteLine(person3 == person4);
//Esse retorna True porque não a tipos referencias (Referencial type) no record, no caso não
//há mais o array PhoneNumbers

//Non-destructive Mutation (copy)
Person person5 = person2 with { LastName = "Brewisk"}; //Copia os dados de person2 e apenas altera o LastName para o novo desejado
Console.WriteLine(person5.ToString());

public record Person(string FirstName, string LastName, string[] PhoneNumbers);
public record PersonWithoutNumber(string FirstName, string LastName);