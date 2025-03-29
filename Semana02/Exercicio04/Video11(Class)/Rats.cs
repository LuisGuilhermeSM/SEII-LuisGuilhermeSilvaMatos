namespace ConsoleApp
{
    public class Rat
    {
        public string? Name { get; set; }   // O ? na frente de string é para dizer que a variavel pode receber um valor nulo. Isso foi para tirar o warning
        public int Number { get; set; }     //O get e set controla o acesso da variavel em outras partes do codigo fora da classe
        public bool IsRadioctive { get; set; }


    }
}
