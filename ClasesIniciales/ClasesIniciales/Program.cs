using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesIniciales
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto de inicio o entradad de mi programa

            //Tipo
            DispositivoMovil miIphone = new DispositivoMovil();
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resoluAlto = 1080;
            miIphone.resoluAncho = 1920;
            miIphone.color = new Color();
            miIphone.color.rojo =100;
            miIphone.color.verde = 20;
            miIphone.color.azul = 210;

            DispositivoMovil tabletSamsung = new DispositivoMovil();
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.ram = 8;
            tabletSamsung.resoluAlto = 1080;
            tabletSamsung.resoluAncho = 1920;

            //ejercicio mi telefono
            DispositivoMovil RedmiNote8 = new DispositivoMovil();
            RedmiNote8.Announced = 2019;
            RedmiNote8.Status = "Available";
            RedmiNote8.Build = "Glass front (Gorilla Glass 5)";
            RedmiNote8.Sim = "dual Sim";
            RedmiNote8.Type = "IPS LCD";
            RedmiNote8.TamAlto = 9.5f;
            RedmiNote8.TamAnch = 6.7f;
            RedmiNote8.resoluAlto = 2340;
            RedmiNote8.resoluAncho = 1080;
            RedmiNote8.Protection = "Gorilla Glass 5";
            RedmiNote8.OS = "Abdroid 9.0";
            RedmiNote8.Chipset = "Qualcomm";
            RedmiNote8.CPU = "Octa Core";
            RedmiNote8.GPU = "Adreno 610";
            RedmiNote8.CardSlot = "micro SDXC";
            RedmiNote8.InternalGB = 32;
            RedmiNote8.QuadMP = "48MP, 8MP, 2MP, 2MP";
            RedmiNote8.Video = "4k 30 fps";
            RedmiNote8.SelfieCamSingle = "13 MP, F/2.0, 1/3.1";
            RedmiNote8.SelfieCamFeatures = "HDR, panorama";
            RedmiNote8.SelfieCamVideo = "1080p 30fps";










        }
    }
}
