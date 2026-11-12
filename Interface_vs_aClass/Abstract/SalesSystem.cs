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
        cashRegister.CreateReceipt(receipt);
        cashRegister.SaveReceipt(receipt);
    }
}

