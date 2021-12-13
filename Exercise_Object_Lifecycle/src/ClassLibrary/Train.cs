using System;

namespace ClassLibrary
{
    public class Train
    {
        public bool IsEngineStarted { get; private set; }

        private static int count = 0;

        private string _id; //visibilidad de la variable 

        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public static int Count 
        // no usamos set para evitar que alguien sette el contador a un numero que no corresponde
        {
            get
            {
                return Train.count; // porque es variable de clase y no de instancia
            }
        }

        public Train(string _id)    //constructor
        {
            this.Id=_id;
            count++;
        }

        ~Train()    //destructor
        {
            count--;
        }

        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
    }
}