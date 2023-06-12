using proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBanco cuentaAhorro1 = new CuentaBanco(1,200);
            //CuentaBanco cuentaAhorro2 = cuentaAhorro1;

            CuentaBanco cuentaClonada = (CuentaBanco) cuentaAhorro1.Clone();

            cuentaAhorro1.Display("cuentaAhorro1");
            //cuentaAhorro2.Display("cuentaAhorro2");
            cuentaClonada.Display("cuentaClonada");  

            cuentaClonada.setMonto(1200);

            cuentaAhorro1.Display("cuentaAhorro1");
            cuentaClonada.Display("cuentaClonada");
            //cuentaAhorro2.setMonto(300);
            cuentaAhorro1.Display("cuentaAhorro1");
            //cuentaAhorro2.Display("cuentaAhorro2");

            Console.WriteLine($"\n{cuentaAhorro1 == cuentaClonada}");
            //Console.WriteLine($"\n{cuentaAhorro1 == cuentaAhorro2}");

            Console.ReadLine();
        }
    }
  
}
