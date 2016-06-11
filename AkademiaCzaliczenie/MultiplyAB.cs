using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCzaliczenie
{
    public class MultiplyAB : Operation
    {
        public override float OperationResult()
        {
            return this.a * this.b;
        }
    }
}
