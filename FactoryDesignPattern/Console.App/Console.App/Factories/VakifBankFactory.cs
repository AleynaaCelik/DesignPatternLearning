using Console.App.Abstractions;
using Console.App.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Factories
{
    public class VakifBankFactory : IBankFactory
    {
        public IBank GetBank()
        {
            var customerId = "12345";

            var bank = new VakifBank(customerId);
            return bank;
        }
    }
}
