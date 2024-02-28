using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessAccount account= new BussinessAccount(100,8010,"bob",500);
            Console.WriteLine(account.Balance);
            // account.Balance=200;
        }
    }
}