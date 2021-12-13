using System;
using System.Text;

namespace Library
{
    public class Person
    {
        private string name;
        private string id;
        private string phoneNumber;

        public Doctor Doctor {get; set;}

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
                        Console.WriteLine("Unable to schedule appointment, Name is required\n");
                    }
                    else
                    {
                        this.name=value;
                    }
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Unable to schedule appointment, id is required\n");
                }
                else
                {
                    this.id=value;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Unable to schedule appointment, Phone number is required\n");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
        public Person (string name, string id, string phoneNumber,Doctor doctor)
        {
            this.Name=name;
            this.Id=id;
            this.PhoneNumber=phoneNumber;
            this.Doctor=doctor;
            Console.WriteLine($"{this.Name} con el dr {this.Doctor.Name}");
        }
    }
}