using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    class Adapter : ITarget
    {

        private readonly Adaptation _adaptt;

        public Adapter(Adaptation adapt)
        {
            this._adaptt = adapt;
        }

        public string GetRequest()
        {
            return $"To jest: {this._adaptt.GetSpecificRequest()}";
        }
    }
}
