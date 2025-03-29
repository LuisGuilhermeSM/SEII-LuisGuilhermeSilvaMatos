using Video16_Static_;

//Os métodos, variaveis, etc declarados static em uma classe podem ser acessados sem que a classe seja instanciada
Console.WriteLine($"Printando sem ter instanciado a classe SavingAccount num objeto: SavingAccount.bondRate = {SavingAccount.bondRate}");
Console.WriteLine($"Printando sem ter instanciado a classe SavingAccount num objeto: SavingAccount.currInterestRate = {SavingAccount.currInterestRate}");
SavingAccount.AddBondRate(); //Como o método é static ele pode ser chamado sem que a classe seja instanciada
Console.WriteLine("Printando sem ter instanciado a classe SavingAccount num objeto" +  
"\ne após ter alterado o valor de SavingAccount pelo uso do método AddBondRate:" +
$"SavingAccount.currInterestRate = {SavingAccount.currInterestRate}"); //Aqui o valor de SavingAccount.currInterestRate foi alterado pelo valor de método AddBondRate()


SavingAccount savingsAccount1 = new SavingAccount();
SavingAccount savingsAccount2 = new SavingAccount();
/*
//Console.WriteLine(savingsAccount1.currInterestRate);
//Console.WriteLine(savingsAccount2.currInterestRate);

//savingsAccount1.currInterestRate = 0;

//Console.WriteLine(savingsAccount1.currInterestRate);
//Console.WriteLine(savingsAccount2.currInterestRate);

Como as variaveis são static não é possível acessar elas por um objeto apenas pela classe não instanciada como feito anteriormente
Apresentou o erro:
error CS0176: O membro "SavingAccount.currInterestRate" não pode ser acessado com uma referência de instância; qualifique-o com um nome de tipo
*/

TimeUtility.PrintTime(); //Como a classe TimeUtility foi declarada como static não é preciso inicializala para usar seus métodos
Console.WriteLine(TimeUtility.valorTeste);
//É como se na compilação do código já fosse criado um objeto chamado TimeUtility 
//e fosse possível utilizar todo dele sem inicializar um objeto no código em si
//Um exemplo de classe criada assim é o Console que utilizamos seus métodos como
//Console.WriteLine() sem inicializar um objeto Console

/*
TimeUtility time1 = new TimeUtility();
time1.valorTeste = 0;
Console.WriteLine(TimeUtility.valorTeste);

TimeUtility time2 = new TimeUtility();
Console.WriteLine(TimeUtility.valorTeste);

Isso dará erro:
 error CS0712: Não é possível criar uma instância da classe estática "TimeUtility"
*/