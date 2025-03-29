Console.WriteLine(Warning.CodeYellow);       // Printa CodeYellow não o interger
Console.WriteLine((int)Warning.CodeYellow);  //Tem que fazer o casting para ele printar o interger

var status = Warning.CodeYellow;

Console.WriteLine(typeof(Warning)); 


if(status == Warning.CodeYellow)
{
    Console.WriteLine("Code Yellow");
}


enum Warning
{
    CodeRed,
    CodeBlue,
    CodeYellow

}