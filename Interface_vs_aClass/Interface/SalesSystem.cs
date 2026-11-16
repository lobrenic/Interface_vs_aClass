using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

internal class SalesSystem
{
    private readonly  ICashRegister cashRegister;
    
    public SalesSystem(ICashRegister register)
    {
        cashRegister = register;
    }
    public void SendReceipt(Receipt receipt)
    {
        if(cashRegister is IGuidRegister guidRegister)
        {
            Guid? guid = guidRegister.getGuid();
            if(guid is null || guid == Guid.Empty)
            {
                Console.WriteLine($"GUID nije vracen, racun {receipt.Number} se ne salje.");
                return;
            }
            guidRegister.setGuid(guid.Value);
        }
        cashRegister.createReceipt(receipt);
        cashRegister.saveReceipt(receipt);
    }

}

