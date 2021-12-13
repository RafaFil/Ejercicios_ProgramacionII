using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterNegative : IFilter
    {
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    Color originalColor = result.GetColor(x,y);

                    byte rOriginal = originalColor.R;
                    byte gOriginal = originalColor.G;
                    byte bOriginal = originalColor.B;

                    byte rNegative = Convert.ToByte(Math.Abs(rOriginal - byte.MaxValue));
                    byte gNegative = Convert.ToByte(Math.Abs(gOriginal - byte.MaxValue));
                    byte bNegative = Convert.ToByte(Math.Abs(bOriginal - byte.MaxValue));

                    Color negativeColor;
                    negativeColor = Color.FromArgb(rNegative, gNegative, bNegative);

                    result.SetColor(x, y, negativeColor);
                }
            }

            return result;
        }
    }
}
