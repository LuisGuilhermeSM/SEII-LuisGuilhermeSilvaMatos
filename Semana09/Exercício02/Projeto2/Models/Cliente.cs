using System.Security.Cryptography;

namespace Projeto2.Models
{
    public class Cliente
    {
        
        public int Id {  get; set; }
        public string Nome { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public string Telefone {get; set;} = string.Empty;

        public Cliente()
        { }

        public Cliente(int id, string nome, string cpf, string telefone) 
        { 
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone; 
        }


    }
}
