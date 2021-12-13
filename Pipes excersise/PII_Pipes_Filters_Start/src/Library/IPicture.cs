using System;
using System.Drawing;

namespace CompAndDel
{
    /// <summary>
    /// Representa una imagen. Las imagenes son una matriz bidimensional de colores. Adicionalmente, se proveen
    /// operaciones para obtener las dimensiones de la imagen, modificar el tamaño de la imagen, y copiar la imagen a una
    /// nueva.
    /// </summary>
    public interface IPicture
    {
        /// <summary>
        /// Retorna el ancho de la imagen.
        /// </summary>
        Int32 Width { get; }

        /// <summary>
        /// Retorna el alto de la imagen.
        /// </summary>
        Int32 Height { get; }

        /// <summary>
        /// Retorna el color del punto localizado en la posicion (x, y) de la imagen. La esquina superior
        /// izquiera de la matriz corresponde al punto (0,0) y el inferior derecho al (Width - 1, Height -1).
        /// </summary>
        /// <param name="x">La coordenada x del punto.</param>
        /// <param name="y">La coordenada y del punto.</param>
        /// <returns>el color del punto</returns>
        Color GetColor(Int32 x, Int32 y);

        /// <summary>
        /// Establece el color del punto localizado en la posicion (x, y) de la imagen. La esquina superior
        /// izquiera de la matriz corresponde al punto (0,0) y el inferior derecho al (Width - 1, Height -1).
        /// </summary>
        /// <param name="x">La coordenada x del punto.</param>
        /// <param name="y">La coordenada y del punto.</param>
        /// <param name="color">El color a usar para el punto.</param>
        void SetColor(Int32 x, Int32 y, Color color);

        /// <summary>
        /// Modifica el tamaño de la imagen.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Los colores de la imagen deben preservarse.
        /// </para>
        /// <para>
        /// Si la imagen tiene nuevos puntos, estos comienzan en color negro.
        /// </para>
        /// </remarks>
        /// <param name="width">El nuevo ancho de la imagen.</param>
        /// <param name="height">El nuevo largo de la imagen.</param>
        void Resize(Int32 width, Int32 height);

        /// <summary>
        /// Copia la imagen en una nueva imagen.
        /// </summary>
        /// <returns>Una copia de la imagen.</returns>
        IPicture Clone();
    }
}