using System;
using System.Text;

namespace student_scrambler.Commands
{
    class AddCommand : Command
    {

        public AddCommand() : base("Add", "Adds new student", "/add <name>")
        { }

        public override void Run(string[] Arguments)
        {
            if(Arguments.Length < 2)
            {
                Console.WriteLine("Usage: " + Usage);
                return;
            }

            if(Arguments[1].Trim().Equals(string.Empty)) 
            {
                Console.WriteLine("Error: Name is empty");
                return;
            }

            StringBuilder sb = new StringBuilder();

            for(int i = 1; i < Arguments.Length; i++)
            {
                sb.Append(Arguments[i] + " ");
            }

            Program.objectManager.CreateNewStudent(sb.ToString().Trim());
        }
    }
}
