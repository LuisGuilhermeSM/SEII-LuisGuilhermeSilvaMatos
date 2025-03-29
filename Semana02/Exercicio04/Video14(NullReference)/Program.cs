//Para atribuir valor null a uma variavel ela deve ser instanciada com ? após seu tipo
int? a = null;
string? texto = null;

Console.WriteLine(a);

//Console.WriteLine(texto.Length); isso dará erro
Console.WriteLine(texto?.Length); // Isso fuinciona mas é melho fazer checagem lógica para ver se é null e ai realizar o codigo mesmo

//Isso
if (texto == null){
    Console.WriteLine("Texto é Null");
}
else{
    Console.WriteLine(texto.Length);
}  

//Ou isso
if(texto is not null){
    Console.WriteLine(texto.Length);
}

//Ou usa-se o operador ?? que caso o valor seja null já retorna o passado após
Console.WriteLine(texto ?? "Valor vazio");

//Ou usa um tary operator
Console.WriteLine(texto is not null ? "Caso não seja null executa o colocado aqui" : "Caso seja null executa o colocado aqui");

Console.WriteLine(texto is not null ? texto.Length : "Valor da variável é null não há length");
texto = "Mudou";
Console.WriteLine(texto is not null ? texto.Length : "Valor da variável é null não há length");