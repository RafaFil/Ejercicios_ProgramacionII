using System;
using System.Collections.Generic;
using System.Text;

namespace CompAndDel
{
    /// <summary>
    /// Una cañería a traves de la cual pasa una imagen.
    /// </summary>
    public interface IPipe
    {
        /// <summary>
        /// Envia un imagen a traves de la cañería.
        /// </summary>
        /// <param name="picture">La imagen a enviar.</param>
        /// <return>La imagen enviada.</return>
        IPicture Send(IPicture picture);
    }
}
