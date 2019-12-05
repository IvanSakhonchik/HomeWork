using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class ExitCommand:ICommand
    {
        ExitReceiver receiver;

        public ExitCommand(ExitReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ExitСonsole();
        }
    }
}
