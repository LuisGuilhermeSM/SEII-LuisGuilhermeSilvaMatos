using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Video12_Metodos_
{
    public class RealState
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }


        //Métodos
        /*
        public int CalculatePricePerSquareFoot()
        {
            return Price/SquareFootage;
        } */

        public int CalculatePricePerSquareFoot() => Price / SquareFootage;

    }
}