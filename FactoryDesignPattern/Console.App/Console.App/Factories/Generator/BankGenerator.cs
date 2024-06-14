using Console.App.Abstractions;
using Console.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Factories.Generator
{
    public static class BankGenerator
    {
        public static IBank Generate(BankType bankType)
        {
            IBankFactory bankFactory = bankType switch
            {
                BankType.Akbank => new AkbankFactory(),
                BankType.VakifBank => new VakifBankFactory(),
                BankType.Ziraat => new ZiraatFactory(),
            };

            var bank = bankFactory.GetBank();

            return bank;
        }
    }
}
