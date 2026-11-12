using System;
using System.Collections.Generic;
using System.Text;
namespace Abs;

internal class Receipt
{
    public string Number { get; set; }
    public decimal AmountNoTax { get; set; }
    public decimal Tax { get; set; }

    public Receipt(string number, decimal amountNoTax, decimal tax)
    {
        Number = number;
        AmountNoTax = amountNoTax;
        Tax = tax;
    }
}

