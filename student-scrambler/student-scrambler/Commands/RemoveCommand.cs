using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class RemoveCommand : Command
    {

        public RemoveCommand() : base("Remove", "Removes specified student")
        { }

        public override void Run(string[] Arguments)
        {
            Program.objectManager.DeleteStudent(Arguments[1]);
        }
    }
}
