using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloNombres
{
    class CuentaBancaria
    {
        private int pin;
        private int saldo;

        public void setPin(int pin)
        {
            pin = ;
        }

        public int getPin()
        {
            return pin;
        }

        public void setSaldo(int saldo)
        {
            saldo = ;
        }

        public int getSaldo()
        {
            if (pin > 0)
            {
                return saldo;


            }
            else
            {
                Console.Write("El saldo no pudo ser recuperado");
            }
            
        }
    }
}
