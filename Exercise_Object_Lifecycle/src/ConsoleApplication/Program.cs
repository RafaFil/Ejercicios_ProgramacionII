using System;
using ClassLibrary;

namespace ConsoleApplication
{
    public static class Program
    {
        public static void Main()
        {
            int n = 100 ;
            for (int i=1; i <=n; i++)
            {
                string myString = i.ToString();
                var train = new Train(myString);    // que es el var?
            }
            var t1= new Train("Last Train to London");
            var t2= new Train("Last Train to London");
            var t3= new Train("Runaway Train");
            Console.WriteLine($"{t1==t2} {t2==t3}");
            Console.WriteLine(Train.Count); // llamamos una variable de clase, porque Count es una variable static de clase XD
        }
    }
}