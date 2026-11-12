using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

public class CashRegister1 : ICashRegister
{
    public void createReceipt(Receipt racun)
    {
        Console.WriteLine($"Kasa 1: kreiran racun broj {racun.Number}");
    }
    public void saveReceipt(Receipt racun)
    {
        Console.WriteLine($"Kasa 1: sacuvan je racun broj {racun.Number}");
    }

}


