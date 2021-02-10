using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler.Commands
{
    class GroupCommand : Command
    {

        public GroupCommand() : base("Group", "Creates specified amount of groups", "/group <amount>")
        { }

        public override void Run(string[] Arguments)
        {
            if(Arguments.Length < 2)
            {
                Console.WriteLine("Usage: " + Usage);
                return;
            }

            int groups = 0;
            int students = Program.objectManager.Students.Count;
            try
            {
                groups = int.Parse(Arguments[1]);
            } catch(Exception)
            {
                Console.WriteLine("Usage: " + Usage);
                return;
            }

            Console.WriteLine("Groups: " + groups);
            Console.WriteLine("Students: " + Program.objectManager.Students.Count);

            if(groups > students)
            {
                Console.WriteLine("Cannot create that many groups, there are only " + students + " students");
                return;
            }



            

        }

    }
}
