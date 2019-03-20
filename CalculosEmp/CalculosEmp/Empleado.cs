using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosEmp
{
    public class Empleado
    {
        public String nom;
        public double sueldo;


        public Empleado()
        {
            this.nom = "";
            this.sueldo = 0;
        }


        public Empleado(string n)
        {
            nom = n;
        }


        public void Sueldo(double s)
        {
            sueldo = s;
        }

        public string RNombre()
        {
            return nom;
        }

        public double RSueldo()
        {
            return sueldo;
        }


        public void Imprimir()
        {
            Console.WriteLine(nom + " su sueldo es: " + sueldo);
        }

        
    }
}
