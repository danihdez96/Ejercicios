using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosEmp
{
     public class Principal
    {

         Empleado emp1; 
        static void Main(string[] args)
        {
            Principal obj = new Principal();

            obj.DatosSueldo();
            obj.DatosEmp();

            Console.ReadKey();
        }

         public Principal()
        {
            emp1 = new Empleado("Margarita");
        }

         public void DatosSueldo()
         {
             emp1.Sueldo(5000.00);
         }



         public void DatosEmp()
         {
             if (emp1.RSueldo()>3000)
             {
                 Console.WriteLine(emp1.RNombre() + " con sueldo " + emp1.RSueldo());
                 Console.WriteLine("Debe pagar impuestos");
             }
             else
             {
                 Console.WriteLine(emp1.RNombre() + " con sueldo " + emp1.RSueldo());
                 Console.WriteLine("No debe pagar impuestos");
             }
         }
    }
}
