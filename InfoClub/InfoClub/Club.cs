using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoClub
{
    class Club
    {
        Socio sc1, sc2, sc3;
        static void Main(string[] args)
        {
            Club cb = new Club();

            cb.Datos();
            cb.infoSocio();

            Console.ReadKey();
        }


        public Club()
        {
            sc1 = new Socio("Alejandro");
            sc2 = new Socio("Cecilia");
            sc3 = new Socio("Rodrigo");
        }


        public void Datos()
        {
            sc1.Año(20);
            sc2.Año(25);
            sc3.Año(39);
        }


        public void infoSocio()
        {
 
                Console.WriteLine(sc1.RetornarNombre() + " tiene " + sc1.RetornarAño() + " años en el club");
                Console.WriteLine(sc2.RetornarNombre() + " tiene " + sc2.RetornarAño() + " años en el club");
                Console.WriteLine(sc3.RetornarNombre() + " tiene " + sc3.RetornarAño() + " años en el club");

        }
    }
}
