using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Bob",0.0);
            BussinessAccount bacc = new BussinessAccount(500.00,1001,"Maria",0.0);

            // UPCASTING
            Account acc1=bacc;
            Account acc2=new BussinessAccount(501.00,1001,"Mo",0.0);

            // DOWNCASTING

            BussinessAccount acc4=(BussinessAccount)acc2;

            BussinessAccount acc5=(BussinessAccount)acc2; // Casting 
            // ou Pode Se Fazer assim // Casting 
            // BussinessAccount acc6=acc2 as BussinessAccount; 
            
            
        }
    }
}