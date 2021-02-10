using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class HelpCommand : Command
    {

        public HelpCommand() : base("Help", "Returns all available commands")
        { }

        public override void Run(string[] Arguments)
        {
            foreach (Command command in Program.commandManager.Commands)
            {
                if (command.Name.ToLower() == "help")
                    continue;
                Console.WriteLine(command.Name);
                Console.WriteLine("  -  " + command.Description);
            }
        }
    }
}
