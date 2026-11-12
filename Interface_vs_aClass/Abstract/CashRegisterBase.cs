using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal abstract class CashRegisterBase
{
    protected string Name { get; }
    protected CashRegisterBase(string name)
    {
        Name = name;
    }
    protected void PrintHeader(Receipt receipt)
    {
        Console.WriteLine($"{Name} | racun {receipt.Number}");
    }
    public abstract void CreateReceipt(Receipt receipt);

    public abstract void SaveReceipt(Receipt receipt);
}

