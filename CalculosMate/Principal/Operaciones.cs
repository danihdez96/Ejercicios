using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Operaciones
    {
        int num1, num2;

        public Operaciones()
        {
            this.num1 = 0;
            this.num2 = 0;
        }



        public Operaciones(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }


        public int RetNum1()
        {
            return num1;
        }

        public int RetNum2()
        {
            return num2;
        }


        public void ImpOpe()
        {
            int resul= num1 + num2;
            Console.WriteLine("el resultado es:" + resul);
        }
    }
}
