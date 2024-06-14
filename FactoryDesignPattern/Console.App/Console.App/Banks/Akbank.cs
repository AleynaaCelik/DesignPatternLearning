using Console.App.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Banks
{
    public class Akbank:IBank
    {
        public Akbank(string accessKey)
        {
            AccessKey = accessKey;
        }

        public string AccessKey { get; set; }

        public void GetPaid(decimal amount)
        {
            System.Console.WriteLine($"{amount} TL has been paid to Akbank with AccessKey: {AccessKey}");
        }
    }
}
