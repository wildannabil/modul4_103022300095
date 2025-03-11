using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300095
{
    internal class FanLaptop
    {
        public enum State { Balance, Turbo }
        public State currentState;

        public FanLaptop()
        {
            currentState = State.Balance;
            Console.WriteLine("Fan Laptop is in Balance state");
        }

        public void handlecomand(string command)
        {
            switch (currentState)
            {
                case State.Turbo:
                    if (command == "turbo")
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Laptop is in Turbo state");
                    }
                    break;
                case State.Balance:
                    if (command == "balance")
                    {
                        currentState = State.Balance;
                        Console.WriteLine("Fan Laptop is in Balance state");
                    }
                    break;
            }
        }
    }

    
}