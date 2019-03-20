using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Principal
    {
        Operaciones op1,op2,op3,op4;
        static void Main(string[] args)
        {
            Principal oper = new Principal();
            oper.Operar();
            oper.CalcOper();

            Console.ReadKey();
        }
        int resul1=0,resul2=0,resul3=0,resul4=0;


       public Principal()
        {
            op1 = new Operaciones(4,9);
            op2 = new Operaciones(7, 6);
            op3 = new Operaciones(10, 31);
            op4 = new Operaciones(18, 4);
        }

        public void Operar()
       {
           op1 = new Operaciones(4, 9);
           op2 = new Operaciones(7, 6);
           op3 = new Operaciones(10, 31);
           op4 = new Operaciones(18, 4);
       }

        public void CalcOper()
       {
           resul1 = op1.RetNum1() + op1.RetNum2();
           resul2 = op2.RetNum1() - op2.RetNum2();
           resul3 = op3.RetNum1() * op3.RetNum2();
           resul4 = op4.RetNum1() / op4.RetNum2();
           Console.WriteLine("El resultado de la suma es " + resul1);
           Console.WriteLine("El resultado de la resta es " + resul2);
           Console.WriteLine("El resultado de la multiplicacion es " + resul3);
           Console.WriteLine("El resultado de la division es " + resul4);
       }
    }
}
