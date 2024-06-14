using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Abstractions
{
    public interface IBank
    {
        void GetPaid(decimal amount);
    }
}
