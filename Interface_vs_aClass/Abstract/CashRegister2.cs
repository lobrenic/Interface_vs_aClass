using Abs;
using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal class CashRegister2 : CashRegisterBase
{
    public CashRegister2() : base("Kasa 2") { }

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
