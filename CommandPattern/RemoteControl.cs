using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    

    class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[3];
            offCommands = new ICommand[3];

            ICommand emptyCommand = new EmptyCommand();
            for (int i = 0; i < 3; i++)
            {
                onCommands[i] = emptyCommand;
                offCommands[i] = emptyCommand;
            }
            undoCommand = emptyCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append($"[Slot {i}] {onCommands[i].GetType().Name}, {offCommands[i].GetType().Name}\n");
            }
            stringBuilder.Append($"[undo] {undoCommand.GetType().Name}\n");
            return stringBuilder.ToString();
        }
    }
}
