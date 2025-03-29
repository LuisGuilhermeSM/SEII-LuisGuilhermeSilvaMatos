using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video16_Static_
{
    public class SavingAccount //Geralmente faz-se public static class SavingAccount
    {
        
        //public static double currInterestRate = 0.4;
        public static double currInterestRate;
        public static double bondRate = 0.3;

        //Para alterar uma variavel (fiel) criado como static o construtor também deve ser instanciado como static
        static SavingAccount()
        {
            currInterestRate = 0.4;
        }

        public static void AddBondRate()
        {
            currInterestRate = bondRate + currInterestRate; // Para fazer operações com uma variável static a outra também deve ser static
        }

    }
}