using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FaceRecognition : IFilterConditional
    {
        public bool conditional {get; set;}  //por IFilterConditional

        private string path;

        public FaceRecognition(string path)
        {
            this.path=path;
        }
        public IPicture Filter(IPicture image)  //por IFIlter
        {
            CognitiveFace face = new CognitiveFace();
            face.Recognize(this.path);
            conditional= face.FaceFound;
            return image;
        }
    }
}