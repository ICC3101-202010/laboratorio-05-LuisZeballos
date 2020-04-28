using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class User
    {
        public delegate void EmailVerificerEventHandler(object source, EventArgs args);

        public event EmailVerificerEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("¿Desea verificar el correo?Si/No");
            string respuesta = Console.ReadLine();
            if(respuesta == "Si" || respuesta == "si")
            {
                OnEmailVerified();
            }
        }
    }
}
