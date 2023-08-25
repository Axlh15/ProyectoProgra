using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInicialesProgra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto de iniciio o de entrada de mi programa
            //Tipo            identificador inicialización
            DispositivoMovil miIphone = new DispositivoMovil(); //declaración e instanciación
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resoluAlto = 1080;
            miIphone.ResoluAncho = 1920;
            miIphone.color = new Color(); //instanciación sin declaración
            miIphone.color.rojo = 100;
            miIphone.color.verde = 20;
            miIphone.color.verde = 210;

            DispositivoMovil tabletSamsung = new DispositivoMovil();
            tabletSamsung.color.rojo = 30;
            tabletSamsung.color.verde = 60;
            tabletSamsung.color.azul = 150;
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.ram = 8;
            tabletSamsung.resoluAlto = 1080;
            tabletSamsung.ResoluAncho = 1920;

            DispositivoMovil Huaweiphone = new DispositivoMovil();
            
            Huaweiphone.almacenamiento = 500;
            Huaweiphone.ram = 16;
            Huaweiphone.resoluAlto = 1080;
            Huaweiphone.ResoluAncho = 1920;
            Huaweiphone.color = new Color();
            Huaweiphone.color.rojo = 50;
            Huaweiphone.color.verde = 100;
            Huaweiphone.color.azul = 37;

        }
    }
}
