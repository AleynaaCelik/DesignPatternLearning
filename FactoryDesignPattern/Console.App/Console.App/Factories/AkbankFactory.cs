using Console.App.Abstractions;
using Console.App.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Factories
{
    public class AkbankFactory : IBankFactory
    {
        public IBank GetBank()
        {
            var accessKey = "your-access-key-aleyna";

            var bank = new Akbank(accessKey);
            return bank;
        }
    }
}
