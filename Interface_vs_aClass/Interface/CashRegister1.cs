using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

public class CashRegister1 : ICashRegister,IGuidRegister
{
    private Guid receiptGuid;

    public Guid getGuid()
    {
        Console.WriteLine("Kasa 1: obavestavam proizvodjaca...");
        return Guid.NewGuid();
    }

    public void setGuid(Guid guid)
    {
        receiptGuid = guid;
    }
    public void createReceipt(Receipt receipt)
    {
        Console.WriteLine($"Kasa 1: kreiran racun broj {receipt.Number}, GUID {receiptGuid}");
    }
    public void saveReceipt(Receipt receipt)
    {
        Console.WriteLine($"Kasa 1: sacuvan racun broj {receipt.Number}, GUID {receiptGuid}");
    }

}


