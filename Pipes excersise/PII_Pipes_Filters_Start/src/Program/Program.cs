using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagePath="luke.jpg";
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(imagePath);
            IPipe nulled = new PipeNull();


            IFilter filtroTwitter = new FilterPublication("Holis", @"intermediateSave.jpg");
            IPipe pipePublicacion = new PipeSerial(filtroTwitter, nulled);

            IFilter negative = new FilterNegative();
            IPipe NegativePipe = new PipeSerial(negative, pipePublicacion);

            IFilter save = new FilterPictureSave(@"intermediateSave.jpg");
            IPipe pipeSave = new PipeSerial(save,NegativePipe);

            IFilterConditional  FaceRecogn = new FaceRecognition(imagePath);
            IPipe conditional = new PipeConditional(pipePublicacion, NegativePipe ,FaceRecogn);

            IFilter grey = new FilterGreyscale();
            IPipe initial = new PipeSerial(grey, pipeSave);

            IPicture resultado = initial.Send(picture);

            provider.SavePicture(resultado, @"save.jpg");
            

        }
    } 
}
