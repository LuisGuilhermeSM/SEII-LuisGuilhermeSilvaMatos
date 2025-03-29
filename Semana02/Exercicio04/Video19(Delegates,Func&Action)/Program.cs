/*var loggerAction = () =>
{
    System.Console.WriteLine("This is simple");
};*/ //Usado o var só para ver que era uma action

Action loggerAction = () =>
{
    System.Console.WriteLine("This is simple");
};

/*var loggerFunc = (int x) =>
{   
    return x + 2;
};*/ //Usado o var só para ver que era uma Func<int, Int>
//Func<int, int> o primeiro int representa os tipos dos parâmetros (argumentos) e o ultimo o tipo do return

Func <int, int> loggerFunc1 = (int x) =>
{   
    return x + 2;
};

//Usando delegate
//Já está inicializando loggerFunc2 como fazendo parte do delegate SuperCustom
SuperCustom loggerFunc2 = (int x) =>
{   
    return x + 2;
};

List<int> list = Enumerable.Range(0, 10).Select(i => i*3).ToList();


var callCall = (Action func) =>
{
    func();
};

callCall(loggerAction);

Console.WriteLine(loggerFunc2(2));

public delegate int SuperCustom(int x);

//Console.WriteLine(SuperCustom(2));

//Obs: Outros exemplos de usos

//Actions
/*using System;
using System.Windows.Forms;

public class TestLambdaExpression
{
   public static void Main()
   {
      Action<string> messageTarget;

      if (Environment.GetCommandLineArgs().Length > 1)
         messageTarget = s => ShowWindowsMessage(s);
      else
         messageTarget = s => Console.WriteLine(s);

      messageTarget("Hello, World!");
   }

   private static void ShowWindowsMessage(string message)
   {
      MessageBox.Show(message);
   }
}*/

//Func
/*Func<string, string> convert = s => s.ToUpper();

string name = "Dakota";
Console.WriteLine(convert(name));

// This code example produces the following output:
//
//    DAKOTA*/


//Delegate
/*
// Create a method for a delegate.
public static void DelegateMethod(string message)
{
    Console.WriteLine(message);
}
// Instantiate the delegate.
Callback handler = DelegateMethod;

// Call the delegate.
handler("Hello World");
*/