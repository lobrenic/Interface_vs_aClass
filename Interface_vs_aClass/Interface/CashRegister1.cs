using Abs;
using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

public class CashRegister1 : ICashRegister
{
    private Guid guid;

    private Guid? notifyManufacturer()
    {
        Console.WriteLine("Kasa 1: obavestavam proizvodjaca");
        return Guid.NewGuid();
    }
    public void createReceipt(Receipt receipt)
    {
        Guid? temp=notifyManufacturer();
        if (temp is null || temp==Guid.Empty)
        {
            throw new InvalidOperationException(
                 $"Kasa 1: proizvodjac nije vratio GUID, racun {receipt.Number} nije kreiran.");
            //Pitanje: Da li da izbacim exception pa da SalesSys mora da primi informaciju o stanju guid
        }
        guid = temp.Value;
        Console.WriteLine($"Kasa 1: kreiran racun broj {receipt.Number}, GUID {guid}");
    }
    public void saveReceipt(Receipt receipt)
    {
        Console.WriteLine($"Kasa 1: sacuvan racun broj {receipt.Number}, GUID {guid}");
    }

}


