using Adry_KN.EF;
using System;

namespace Adry_KN.Servicios
{
    public class UtilitarioService
    {
        public void RegistrarErrorBitacora(string mensaje, string lugar, int usuario)
        {
            using (var context = new KN_BDEntities())
            {
                context.spRegistrarError(mensaje, DateTime.Now, lugar, usuario);
            }
        }

    }
}
