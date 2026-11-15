
using System;
using System.Collections.Generic;
using System.Text;


var ifcReceipt = new Ifc.Receipt("1001", 2000m, 400m);
var ss1I = new Ifc.SalesSystem<Ifc.CashRegister1>();
var ss2I = new Ifc.SalesSystem<Ifc.CashRegister2>();

ss1I.SendReceipt(ifcReceipt);
ss2I.SendReceipt(ifcReceipt);

Console.WriteLine();

var absReceipt = new Abs.Receipt("1001", 2000m, 400m);
var ss1A = new Abs.SalesSystem<Abs.CashRegister1>();
var ss2A = new Abs.SalesSystem<Abs.CashRegister2>();

ss1A.SendReceipt(absReceipt);
ss2A.SendReceipt(absReceipt);