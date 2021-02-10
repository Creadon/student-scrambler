using student_scrambler.Commands;
using System;
using System.Collections.Generic;

namespace student_scrambler
{
    class CommandManager
    {

        public List<Command> Commands
        {
            get; private set;
        }

        public CommandManager()
        {
            Commands = new List<Command>();

            Commands.Add(new HelpCommand());
            Commands.Add(new ListCommand());
            Commands.Add(new AddCommand());
            Commands.Add(new RemoveCommand());

            Console.WriteLine("Use command 'Help' for a list of commands.");
        }

        public void RunCommand(string Input)
        {
            Console.Clear();

            string[] Arguments = Input.Split(' ');

            foreach(Command command in Commands)
            {
                if(command.Name.ToLower() == Arguments[0].ToLower())
                {
                    command.Run(Arguments);
                }
            }
        }

    }
}
