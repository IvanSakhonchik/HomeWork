using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }

    }
}
