using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype30_oct
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos instancias
            AutoProto prototipoHonda = new HondaPrototype();
            AutoProto prototipoSubaru = new SubaruPrototype();
            AutoProto prototipoNissan = new NissanPrototype();

            AutoProto HondaCivic = prototipoHonda.Clonar();
            HondaCivic.Modelo = "CIVIC";
            HondaCivic.Color = "Azul";
            Console.WriteLine(HondaCivic.VerAuto());

            AutoProto HondaFit = prototipoHonda.Clonar();
            HondaFit.Modelo = "FIT";
            HondaFit.Color = "blanco";
            Console.WriteLine(HondaFit.VerAuto());

            AutoProto subaru1 = prototipoSubaru.Clonar();
            subaru1.Modelo = "impresa";
            subaru1.Color = "Blanco";
            Console.WriteLine(subaru1.VerAuto());

            AutoProto s2 = prototipoSubaru.Clonar();
            s2.Modelo = "forester";
            s2.Color = "negro";
            Console.WriteLine(s2.VerAuto());

            AutoProto centra = prototipoNissan.Clonar();
            centra.Modelo = "centra";
            centra.Color = "negro";
            Console.WriteLine(centra.VerAuto());

            AutoProto skyline = prototipoNissan.Clonar();
            skyline.Modelo = "skyline";
            skyline.Color = "gris";
            Console.WriteLine(skyline.VerAuto());

            Console.ReadKey();
        }
    }
}
