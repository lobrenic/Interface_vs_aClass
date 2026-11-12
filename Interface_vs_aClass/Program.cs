using System;
using System.Collections.Generic;
using System.Text;


var ifcReceipt = new Ifc.Receipt("1001", 2000m, 400m);
new Ifc.SalesSystem(new Ifc.CashRegister1()).SendReceipt(ifcReceipt);
new Ifc.SalesSystem(new Ifc.CashRegister2()).SendReceipt(ifcReceipt);

Console.WriteLine();

var absReceipt = new Abs.Receipt("1001", 2000m, 400m);
new Abs.SalesSystem(new Abs.CashRegister1()).SendReceipt(absReceipt);
new Abs.SalesSystem(new Abs.CashRegister2()).SendReceipt(absReceipt);