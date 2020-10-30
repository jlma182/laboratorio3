using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype30_oct
{
    public class SubaruPrototype : AutoProto
    {
        public override AutoProto Clonar()
        {
            // devuelve una copia transformada al tipo subaruprototype
            return (SubaruPrototype)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"subaru {_modelo} color {_color}";
        }
    }
}
