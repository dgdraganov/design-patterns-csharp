using System.Collections.Generic;
using System;
namespace design_patterns_csharp.Command.Components
{
    public class TVController
    {
        Dictionary<string, ICommand> commands { get; }
        public TVController()
        {
            commands = new Dictionary<string, ICommand>();
        }

        public void AddCommand(string cmdName, ICommand command)
        {
            if(commands.ContainsKey(cmdName))
            {
                throw new ArgumentException();
            }

            commands.Add(cmdName, command);
        }

        public void Invoke(string cmdName)
        {
            if (commands.ContainsKey(cmdName))
            {
                commands[cmdName].Execute();
            }
        }
    }
}