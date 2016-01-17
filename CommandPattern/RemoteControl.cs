using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        IList<ICommand> allCommands;

        public RemoteControl()
        {
            allCommands = new List<ICommand>();
        }

        public void ExecuteButtonPressed(ICommand command)
        {
            command.Execute();
        }

        public void UndoButtonPressed(ICommand command)
        {
            command.Undo();
        }

        public void RegisterCommand(ICommand command)
        {
            if(!allCommands.Contains(command))
            {
                allCommands.Add(command);
            }
        }
    }
}
