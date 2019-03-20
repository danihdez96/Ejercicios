using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoClub
{
    public class Socio
    {
        private String nombre;
        private int año;

        //Constructor
         public Socio()
        {

            this.nombre = "";    
            this.año = 0;

        }  


        public Socio(string nom)
        {

            nombre = nom;

        }

        public void Año(int a)
        {
            año = a;
        }


        public int RetornarAño()
        {
            return año;
        }


        public string RetornarNombre()
        {
            return nombre;
        }


        public void ImpInfo()
        {
            
            Console.WriteLine(nombre + " tiene " + año + " de antigüedad");
            
        }
    }
}
