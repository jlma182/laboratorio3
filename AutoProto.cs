using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype30_oct
{
    public abstract class AutoProto
    {
        //atributos internos
        protected string _color;
        protected string _modelo;
        //para dar suss caracteristicas realizamos set's 
        public string Color
        {
            set => _color = value;
        }
        public string Modelo
        {
            set => _modelo = value;
        }
        
        //quiero devorlver un prototipo de un auto
        public abstract AutoProto Clonar();
        //simple. ver auto
        public abstract string VerAuto();
    }

}
