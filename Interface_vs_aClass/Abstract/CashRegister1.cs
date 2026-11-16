using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
namespace Abs;

internal class CashRegister1:CashRegisterBase
{
    private Guid receiptGuid;
    public CashRegister1():base("Kasa 1") { }

    public override bool UsesGuid => true;
    public override Guid? GetGuid()
    {
        Console.WriteLine("Kasa 1: obavestavam proizvodjaca...");
        return Guid.NewGuid();
    }

    public override void SetGuid(Guid guid)
    {
        receiptGuid = guid;
    }
    public override void CreateReceipt(Receipt receipt)
    {
        
        PrintHeader(receipt);
        Console.WriteLine($"Kreiran racun, GUID {receiptGuid}");
    }

    public override void SaveReceipt(Receipt receipt)
    {
        Console.WriteLine($"Sacuvan racun, GUID {receiptGuid}");
    }
}

