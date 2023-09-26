using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConstructores
{
    public class Email
    {
        private string subject = "notas";
        private string contenido = "huevos, leche, etc.";
        private string destinatario = "Maria";


        public Email(string textoSubject, string textoContenido, string textoDestinatario)
        {
            subject = textoSubject;
            contenido = textoContenido;
            destinatario = textoDestinatario;

        }

        public void leerEmail()// escribe pero no devuelve nada
        {
            Console.ReadLine(subject,contenido,destinatario);

        }

     
    }
}
