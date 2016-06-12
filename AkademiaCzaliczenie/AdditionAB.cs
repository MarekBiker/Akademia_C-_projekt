using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCzaliczenie
{
    public class AdditionAB : ICoperation
    {
        public float a { get; set; }
        public float b { get; set; }
        public float OperationResult()
        {
            return this.a + this.b;
        }
    }
}
