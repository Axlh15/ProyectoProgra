using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancosGettersSetters
{
    class CuentaBancaria
    {
        private int pin;
        private int saldo;

        public void setPin(int pinNum)
        {
            pin = pinNum;
        }

        public int getPin()
        {
            return pin;
        }

        public void setSaldo(int saldoNum)
        {
            saldo = saldoNum;
        }

        public int getSaldo()
        {
            if (pin > 0)
            {
           


            }
            else
            {
                Console.Write("El saldo no pudo ser recuperado");
            }
            return saldo;
        }
    }
}
