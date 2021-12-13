using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterPublication : IFilter
    {
        private string textPost;
        private string path;

        public FilterPublication(string textPost, string path) 
        {
            this.textPost=textPost;
            this.path=path;
        }

        public IPicture Filter(IPicture image)
        {
            TwitterImage twitter = new TwitterImage();       // extraido de la documentacion
            System.Console.WriteLine(twitter.PublishToTwitter(this.textPost , this.path));
            return image;
        }
    }
}