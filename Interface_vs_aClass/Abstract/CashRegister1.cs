using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
namespace Abs;

internal class CashRegister1:CashRegisterBase
{
    private Guid guid;
    public CashRegister1():base("Kasa 1") { }

    private Guid? NotifyManufacturer()
    {
        Console.WriteLine("Kasa 1: obavestavam proizvodjaca...");
        return Guid.NewGuid();   
    }
    public override void CreateReceipt(Receipt receipt)
    {
        Guid? result = NotifyManufacturer();

        if (result is null || result == Guid.Empty)
        {
            throw new InvalidOperationException(
                $"Kasa 1: proizvodjac nije vratio GUID, racun {receipt.Number} nije kreiran.");
        }

        guid = result.Value;
        PrintHeader(receipt);
        Console.WriteLine("Kreiran racun");
    }

    public override void SaveReceipt(Receipt receipt)
    {
        Console.WriteLine($"Sacuvan racun, GUID {guid}");
    }
}

