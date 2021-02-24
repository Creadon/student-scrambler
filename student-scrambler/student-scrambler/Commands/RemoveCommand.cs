using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class RemoveCommand : Command
    {

        public RemoveCommand() : base("Remove", "Removes specified student", "/remove <name | id>")
        { }

        public override void Run(string[] Arguments)
        {
            if (Arguments.Length < 2)
            {
                Console.WriteLine("Usage: " + Usage);
                return;
            }

            try
            {
                int id = int.Parse(Arguments[1]);

                Program.objectManager.DeleteStudent(id);

                Console.WriteLine("Successfully removed " + id);
            } catch(Exception)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 1; i < Arguments.Length; i++)
                {
                    sb.Append(Arguments[i] + " ");
                }

                Program.objectManager.DeleteStudent(sb.ToString().Trim());

                Console.WriteLine("Successfully removed " + sb.ToString().Trim());
            }
        }
    }
}
