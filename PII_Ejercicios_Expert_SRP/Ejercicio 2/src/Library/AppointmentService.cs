using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static void CreateAppointment(DateTime date, string appoinmentPlace, Doctor doctor,Person person )
        {
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, Appoinment place is required\n");
            }
            Console.WriteLine("Appointment successful");
        }
    }
}
