using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Cuenta
    {
        private int IdCuenta;
        private string Usuario;
        private double saldoInicial;

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {
            IdCuenta = idCuenta;
            Usuario = usuario;
            this.saldoInicial = saldoInicial;
        }

        public int getIdCuenta()
        {
            return this.IdCuenta;
        }
        
        public void setIdCuenta(int idcuenta)
        {
            this.IdCuenta = idcuenta;
        }
        public string getUsuario()
        {
            return this.Usuario;
        }

        public void setUsuario(string usuario)
        {
            this.Usuario = usuario;
        }

        public double getSaldo()
        {
            return saldoInicial;
        }

        public void setSaldo(double saldo)
        {
            this.saldoInicial = saldo;
        }
    }
}
