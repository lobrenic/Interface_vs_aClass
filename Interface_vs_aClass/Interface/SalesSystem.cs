using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

internal class SalesSystem<T> where T:ICashRegister,new()
{
    private readonly T cashRegister=new T();
    
    public void SendReceipt(Receipt receipt)
    {
        cashRegister.createReceipt(receipt);
        cashRegister.saveReceipt(receipt);
    }

}

