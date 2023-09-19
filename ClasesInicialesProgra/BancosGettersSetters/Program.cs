using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancosGettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaUno = new CuentaBancaria();

            cuentaUno.setPin(0);
            cuentaUno.getPin();

            cuentaUno.setSaldo(751);
            cuentaUno.getSaldo();
            Console.ReadLine();
        }
    }
}
