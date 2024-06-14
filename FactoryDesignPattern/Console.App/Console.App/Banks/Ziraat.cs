using Console.App.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Banks
{
    public class Ziraat:IBank
    {
        public Ziraat(string email, Guid customerKey)
        {
            Email = email;
            CustomerKey = customerKey;
        }

        public string Email { get; set; }
        public Guid CustomerKey { get; set; }

        public void GetPaid(decimal amount)
        {
            System.Console.WriteLine($"{amount} TL has been paid to Ziraat with Email: {Email} and CustomerKey: {CustomerKey}");
        }
    }
}
