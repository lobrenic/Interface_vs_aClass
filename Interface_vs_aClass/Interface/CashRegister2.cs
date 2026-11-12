using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;
internal class CashRegister2 : ICashRegister
    {
    public void createReceipt(Receipt racun)
    {
        Console.WriteLine($"Kasa 2: kreiran racun broj {racun.Number}");
    }
    public void saveReceipt(Receipt racun)
    {
        Console.WriteLine($"Kasa 2: sacuvan je racun broj {racun.Number}");
    }
}

