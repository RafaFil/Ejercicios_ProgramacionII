using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace CompAndDel
{
    /// <summary>
    /// Esta clase permite leer y guardar imágenes desde archivos.
    /// </summary>
    public class PictureProvider
    {
        /// <summary>
        /// Lee una imagen desde un archivo.
        /// </summary>
        /// <param name="path">El path del archivo desde el cual leer la imagen.</param>
        /// <returns>La imagen leida.</returns>
        public IPicture GetPicture(string path)
        {
            Picture picture = new Picture(1, 1);
            using (var image = Image.Load(path))
            {
                picture.Resize(image.Width, image.Height);
                for (int h = 0; h < image.Height; h++)
                {
                    for (int w = 0; w <image.Width; w++)
                    {
                        picture.SetColor(w, h, Color.FromArgb(image[w, h].A, image[w, h].R, image[w, h].G, image[w, h].B));
                    }
                }
            }
            return picture;
        }

        /// <summary>
        /// Guarda una imagen en un archivo.
        /// </summary>
        /// <param name="picture">La imagen a guardar.</param>
        /// <param name="path">El path del archivo donde guardar la imagen.</param>
        public void SavePicture(IPicture picture, string path)
        {
            int width = picture.Width;
            int height = picture.Height;
            using(Image<Rgba32> image = new Image<Rgba32>(width, height)) // creates a new image with all the pixels set as transparent
            {
                for (int h = 0; h < picture.Height; h++)
                {
                    for (int w = 0; w < picture.Width; w++)
                    {
                        Color c = picture.GetColor(w, h);
                        image[w, h] = new Rgba32(c.R, c.G, c.B, c.A);
                    }
                }
                image.Save(path);
            }
        }
    }
}