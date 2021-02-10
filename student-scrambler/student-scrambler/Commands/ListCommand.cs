using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class ListCommand : Command
    {

        public ListCommand() : base("List", "Lists all students")
        { }

        public override void Run(string[] Arguments)
        {
            foreach (Student student in Program.objectManager.Students)
                Console.WriteLine(student.Name);
        }
    }
}
