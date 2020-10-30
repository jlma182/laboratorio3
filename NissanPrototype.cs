using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype30_oct
{
    public class NissanPrototype : AutoProto
    {
        public override AutoProto Clonar()
        {
            return (NissanPrototype)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"Nissan {_modelo} color {_color}";
        }
    }
}
