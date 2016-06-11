using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCzaliczenie
{
    public class Operation
    {
        public float a { get; set; }
        public float b { get; set; }

        public virtual float OperationResult()
        {
            return 0;
        }
    }
}
