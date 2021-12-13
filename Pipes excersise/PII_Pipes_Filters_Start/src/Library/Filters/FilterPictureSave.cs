using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterPictureSave  : IFilter   //PARTE 2, creo una clase del tipo filtro experta en guardar.
    {  
        private string path; // inicializo un private string que va a ser 

        public FilterPictureSave (string path)  
        //Constructor del filtro que recive como argumento el path
        {
            this.path= path;
        }
        public IPicture Filter(IPicture image)  //Metodo Filter impuesto por la interface
        {
            PictureProvider p = new PictureProvider();
            p.SavePicture(image, this.path);        // Guardo la imagen
            return image;
        }
    }
}