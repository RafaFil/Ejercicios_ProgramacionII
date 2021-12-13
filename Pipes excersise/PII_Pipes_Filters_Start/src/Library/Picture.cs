using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel
{
    /// <summary>
    /// Una implementación de <see cref="IPicture"/> mediante una matriz bidimensional de colores.
    /// </summary>
    public class Picture : IPicture
    {
        private Color[,] colorsMatrix;

        /// <summary>
        /// Crea una nueva instancia de <see cref="Picture"/>.
        /// </summary>
        /// <param name="width">Ancho en pixels de la imagen.</param>
        /// <param name="height">Altura en pixels de la imagen.</param>
        public Picture(Int32 width, Int32 height)
        {
            this.colorsMatrix = new Color[width, height];
            this.colorsMatrix.Initialize();
        }

        /// <summary>
        /// Devuelve el ancho en pixels de la imagen.
        /// </summary>
        public Int32 Width
        {
            get {return this.colorsMatrix.GetLength(0); }
        }

        /// <summary>
        /// Devuelve la altura en pixels de la imagen.
        /// </summary>
        public Int32 Height
        {
            get { return this.colorsMatrix.GetLength(1); }
        }

        /// <summary>
        /// Devuelve el color que compone la imagen en un pixel en particular en coordenadas cartesianas.
        /// </summary>
        /// <param name="x">Coordenada x del pixel a seleccionar.</param>
        /// <param name="y">Coordenada y del pixel a seleccionar.</param>
        /// <returns>Color del pixel seleccionado.</returns>
        public Color GetColor(Int32 x, Int32 y)
        {
            return this.colorsMatrix[x, y];
        }

        /// <summary>
        /// Asigna el color que compone la imagen en un pixel en particular en coordenadas cartesianas.
        /// </summary>
        /// <param name="x">Coordenada x del pixel a seleccionar.</param>
        /// <param name="y">Coordenada y del pixel a seleccionar.</param>
        /// <param name="color">Nuevo color del pixel seleccionado.</param>
        public void SetColor(Int32 x, Int32 y, Color color)
        {
            this.colorsMatrix[x, y] = color;
        }

        /// <summary>
        /// Modifica el tamaño de la imagen. Si la nueva imagen es mas grande, los pixels nuevos se colorean en negro.
        /// </summary>
        /// <param name="width">Nuevo ancho de la imagen en pixels.</param>
        /// <param name="height">Nueva altura de la imagen en pixels.</param>
        public void Resize(Int32 width, Int32 height)
        {
            Color[,] newMatrix = new Color[width, height];
            newMatrix.Initialize();

            int minX, minY;
            minX = Math.Min(width, this.Width);
            minY = Math.Min(height, this.Height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    newMatrix[x, y] = Color.Black;
                }
            }

            for (int x = 0; x < minX; x++)
            {
                for (int y = 0; y < minY; y++)
                {
                    newMatrix[x, y] = this.colorsMatrix[x, y];
                }
            }

            this.colorsMatrix = newMatrix;
        }
        /// <summary>
        /// Devuelve un clon de la imagen.
        /// </summary>
        /// <returns>Clon de la imagen.</returns>
        public IPicture Clone()
        {
            Picture pictureClone = new Picture(this.Width, this.Height);
            for (int x = 0; x < pictureClone.Width; x++)
            {
                for (int y = 0; y < pictureClone.Height; y++)
                {
                    pictureClone.SetColor(x, y, this.colorsMatrix[x,y]);
                }
            }
            
            return pictureClone;
        }
    }
}
