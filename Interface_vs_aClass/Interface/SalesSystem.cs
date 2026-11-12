using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

internal class SalesSystem
{
    private readonly ICashRegister cashRegister;
    public SalesSystem(ICashRegister cashRegister)
    {
        this.cashRegister = cashRegister;
    }
    public void SendReceipt(Receipt receipt)
    {
        cashRegister.createReceipt(receipt);
        cashRegister.saveReceipt(receipt);
    }

}

