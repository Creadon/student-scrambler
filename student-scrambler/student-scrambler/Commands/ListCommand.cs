using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class ListCommand : Command
    {

        public ListCommand() : base("List", "Lists all students", "/list")
        { }

        public override void Run(string[] Arguments)
        {
            Console.WriteLine("There are currently " + Program.objectManager.Students.Count + " students registered");
            foreach (Student student in Program.objectManager.Students)
                Console.WriteLine(student.Id + " " + student.Name);
        }
    }
}
