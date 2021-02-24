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
            Commands.Add(new GroupCommand());

            PrintHeader();
            Console.WriteLine("Use command 'Help' for a list of commands.\n");
        }

        public void RunCommand(string Input)
        {
            Console.Clear();

            string[] Arguments = Input.Split(' ');

            foreach(Command command in Commands)
            {
                if(command.Name.ToLower() == Arguments[0].ToLower())
                {
                    PrintHeader();
                    command.Run(Arguments);
                    Console.WriteLine();
                }
            }
        }

        public void PrintHeader()
        {
            Console.WriteLine("\n  https://github.com/Creadon/student-scrambler \n");
        }

    }
}
