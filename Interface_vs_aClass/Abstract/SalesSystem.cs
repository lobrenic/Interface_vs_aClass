using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal class SalesSystem<T> where T: CashRegisterBase, new()
{
    private readonly T cashRegister=new T();

    public void SendReceipt(Receipt receipt)
    {
        cashRegister.CreateReceipt(receipt);
        cashRegister.SaveReceipt(receipt);
    }
}

