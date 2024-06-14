using Console.App.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Banks
{
    public class VakifBank:IBank
    {
        public VakifBank(string customerId)
        {
            CustomerId = customerId;
        }

        public string CustomerId { get; set; }

        public void GetPaid(decimal amount)
        {
            System.Console.WriteLine($"{amount} TL has been paid to Vakifbank with CustomerId: {CustomerId}");
        }
    }
}
