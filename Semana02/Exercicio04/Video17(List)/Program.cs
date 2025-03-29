//CRUD

//Creat
List<int> numNums1 = new List<int>(); //Isso inicializa uma lista sem elementos vazia
numNums1.Add(102);
Console.WriteLine(numNums1[0]);

List<int> numNums2 = [1, 2, 3, 4, 5];

//Read

string palavra = "Texto de teste";
//Isso foi só para teste, dapara interar sobre strings
foreach (char letra in palavra)
{
    Console.WriteLine(letra);
}

Console.WriteLine(palavra[2]);  // Isso funciona também

Console.WriteLine("\nPrimeira Leitura de numNums2");
foreach (int num in numNums2)
{
    Console.WriteLine(num);
}

//Update
//This is the fastest
numNums2.Add(0);

//Insert
numNums2.Insert(0, 0); //primeiro parâmetro é a posição (index da lista) e o segundo o valor a ser adicionado

Console.WriteLine("\nSegunda Leitura de numNums2, após inserções");
foreach (int num in numNums2)
{
    Console.WriteLine(num);
}

//Delete

Console.WriteLine(numNums2.Where((num) => num != 2)); // Retorna um System.Linq.Enumerable+ListWhereIterator`1[System.Int32]
//Por isso tem que converter para lista no exemplo abaixo

List<int> newNums = numNums2.Where((num) => num != 2).ToList();
Console.WriteLine("\nLeitura de newNums, nova lista filtrada de numNums2");
foreach (int num in newNums)
{
    Console.WriteLine(num);
}

numNums2.RemoveAt(3); //Remove o valor no index (posição) passada

numNums2.Remove(5);   //Remove a primeira ocorrência do valor

Console.WriteLine("\nTerceira Leitura de numNums2, após remoções");
foreach (int num in numNums2)
{
    Console.WriteLine(num);
}