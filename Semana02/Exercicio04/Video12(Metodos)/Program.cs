using Video12_Metodos_;

//RealState elmStreet = new RealState();
RealState elmStreet = new()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 300000
};

Console.WriteLine(elmStreet.CalculatePricePerSquareFoot());

elmStreet.Address = "Mudou endereço";
Console.WriteLine(elmStreet.Address);