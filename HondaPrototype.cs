using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//solo tenemos como metodos el clonar y ver auto
namespace prototype30_oct
{
    public class HondaPrototype : AutoProto
    {
        public override AutoProto Clonar()
        {
            // el menberwiseclone me devolvera una copia superficial siendo un objeto de tipo hondaprototype
            return (HondaPrototype)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"HONDA {_modelo} color {_color}";
        }
    }

}
