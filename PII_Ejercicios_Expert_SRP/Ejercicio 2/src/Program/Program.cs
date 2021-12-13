using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor peralta=new Doctor("Doctor peralta");
            Person persona1= new Person("","120","3",peralta);
            AppointmentService.CreateAppointment(DateTime.Now, "Marte", peralta, persona1);
        }
    }
}
