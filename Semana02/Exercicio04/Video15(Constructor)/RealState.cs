using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video15_Constructor_
{
    public class RealState
    {

        private string _address;  // Isso é chamado de field (variavel de uma classe), não de propriedade
        
        

        public RealState(string address)
        {
            Console.WriteLine("Criando Real State");
            _address = address;  // this._address = address    
        }

        public string Address
        {
            get => _address; 
            set => _address = value;
        } //Isso é uma propriedade, no caso é uma getter e setter para a variável (o field)  _address
        // a keyword value colocada após o set é a responsável por pegar o valor passado no código Program.cs e atribuir ao _address
    }
}