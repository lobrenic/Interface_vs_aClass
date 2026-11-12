namespace Ifc;
public class Receipt
{
    private string number;
    private decimal amountNoTax;
    private decimal tax;
    public Receipt(string number, decimal amountNoTax, decimal tax)
    {
        Number = number;
        AmountNoTax = amountNoTax;
        Tax = tax;
    }

    public string Number
    {
        get;set;
    }
    public decimal AmountNoTax
    {
        get;set;
    }
    public decimal Tax
    {
        get;set;
    }

}
