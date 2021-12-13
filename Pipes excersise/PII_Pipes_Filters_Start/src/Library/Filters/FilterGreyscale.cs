using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y la retorna en escala de grises.
    /// </remarks>
    public class FilterGreyscale : IFilter
    {
        /// <summary>
        /// Un filtro que retorna la imagen recibida con un filtro de escala de grises aplicado.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en escala de grises.</returns>
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    Color colorOriginal = result.GetColor(x, y);

                    byte rOriginal = colorOriginal.R;
                    byte gOriginal = colorOriginal.G;
                    byte bOriginal = colorOriginal.B;
                    int luma = (int)((rOriginal * 0.3) + (gOriginal * 0.59) + (bOriginal * 0.11));
                    Color colorGris;
                    colorGris = Color.FromArgb(luma, luma, luma);
                    result.SetColor(x, y, colorGris);
                }
            }

            return result;
        }
    }
}
