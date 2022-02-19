using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptation adp = new Adaptation();
            ITarget target = new Adapter(adp);

            Console.WriteLine("Interface Adaptation jest niekompatybilny z klientem");
            Console.WriteLine("...ale, za pomocą adaptera klienta moze wywołac właściwą metodę...");

            Console.WriteLine(target.GetRequest());

            Console.ReadKey();
        }
    }
}
