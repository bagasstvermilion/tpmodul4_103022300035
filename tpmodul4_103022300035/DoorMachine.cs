using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300035
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void processCommand(string command)
        {
            switch (currentState)
            {
                case State.Terkunci:
                    if (command == "BUKA")
                    {
                        currentState = State.Terbuka;
                        Console.WriteLine("Pintu tidak terkunci");
                    } else
                    {
                        Console.WriteLine("Pintu tetap trkunci");
                    }
                    break;
                case State.Terbuka:
                    if (command == "KUNCI")
                    {
                        currentState = State.Terkunci;
                        Console.WriteLine("Pintu terkunci");
                    } else
                    {
                        Console.WriteLine("Pintu tetap terbuka");
                    }
                    break;
            }
        }
    }
}
