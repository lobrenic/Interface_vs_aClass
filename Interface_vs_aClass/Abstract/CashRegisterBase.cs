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
    public virtual bool UsesGuid => false;
    public virtual Guid? GetGuid() => null;
    public virtual void SetGuid(Guid guid) { }

    public abstract void CreateReceipt(Receipt receipt);

    public abstract void SaveReceipt(Receipt receipt);
}

