using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal class SalesSystem
{
    private readonly CashRegisterBase cashRegister;
    public SalesSystem(CashRegisterBase cashRegister)
    {
        this.cashRegister = cashRegister;
    }
    public void SendReceipt(Receipt receipt)
    {
        if (cashRegister.UsesGuid)
        {
            Guid? guid =cashRegister.GetGuid();
            if(guid is null || guid == Guid.Empty)
            {
                Console.WriteLine($"GUID nije vracen, racun {receipt.Number} se ne salje.");
                return;
            }
            cashRegister.SetGuid(guid.Value);
        }
        cashRegister.CreateReceipt(receipt);
        cashRegister.SaveReceipt(receipt);
    }
}

