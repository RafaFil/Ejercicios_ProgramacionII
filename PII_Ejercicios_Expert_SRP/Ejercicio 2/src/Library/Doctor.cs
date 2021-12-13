using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string name;
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {   
                    Console.WriteLine("Unable to schedule appointment, Doctor name is required\n");
                }
                else
                {
                    this.name=value;
                }
            }
        }

        public Doctor(string name)
        {
            this.Name=name;
            Console.WriteLine($"Este es el doctor {this.Name}");
        }
    }
}