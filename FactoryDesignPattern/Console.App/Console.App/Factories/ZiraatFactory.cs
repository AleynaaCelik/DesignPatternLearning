using Console.App.Abstractions;
using Console.App.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Factories
{
    public class ZiraatFactory : IBankFactory
    {
        public IBank GetBank()
        {
            var email = "customer@ziraat.com";
            var customerKey = Guid.NewGuid();  // Rastgele bir GUID oluşturuyoruz

            var bank = new Ziraat(email, customerKey);
            return bank;
        }
    }
}
