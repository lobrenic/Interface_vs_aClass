using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal class CashRegister1:CashRegisterBase
{
    public CashRegister1():base("Kasa 1") { }
    public override void CreateReceipt(Receipt receipt)
    {
        PrintHeader(receipt);
        Console.WriteLine("Kreiran racun");
    }

    public override void SaveReceipt(Receipt receipt)
    {
        Console.WriteLine("Sacuvan racun");
    }
}

