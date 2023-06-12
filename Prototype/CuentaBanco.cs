using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class CuentaBanco : Cloneable
    {
        private int id;
        private int monto;

        public CuentaBanco(int id,int monto)
        {
            this.id = id;
            this.monto = monto; 
        }        
        public void setMonto(int monto)
        {
            this.monto= monto;  
        }

        public void Display(string nombre)
        {
            Console.WriteLine($"\n{nombre}\nMonto: {monto}");
        }
        public Cloneable Clone()
        {
            CuentaBanco cuenta = null;
            try
            {
                cuenta = (CuentaBanco) MemberwiseClone();
            }catch (Exception e) { }

            return cuenta;
        }
    }
}
