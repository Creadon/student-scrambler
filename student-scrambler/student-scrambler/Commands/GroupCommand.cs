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

            int groupAmount = 0;
            int studentAmount = Program.objectManager.Students.Count;
            try
            {
                groupAmount = int.Parse(Arguments[1]);
            } catch(Exception)
            {
                Console.WriteLine("Usage: " + Usage);
                return;
            }

            if(groupAmount <= 0)
            {
                Console.WriteLine("Invalid group amount");
                return;
            }

            if(groupAmount > studentAmount)
            {
                Console.WriteLine("Cannot create that many groups, there are only " + studentAmount + " students");
                return;
            }

            Program.objectManager.Groups.Clear();

            int studentsPerGroup = (int)Math.Floor((double)((double)studentAmount / (double)groupAmount));
            int studentsLeftOut = studentAmount - (studentsPerGroup * groupAmount);

            List<Student> availableStudents = Program.objectManager.Students.ToList();
            Random random = new Random();

            List<Group> groups = new List<Group>();

            for(int group = 0; group < groupAmount; group++)
            {
                List<Student> students = new List<Student>();

                for (int student = 0; student < studentsPerGroup; student++)
                {
                    int next = random.Next(0, availableStudents.Count);
                    students.Add(availableStudents[next]);
                    availableStudents.RemoveAt(next);
                }

                if(studentsLeftOut > 0)
                {
                    studentsLeftOut--;
                    int next = random.Next(0, availableStudents.Count);
                    students.Add(availableStudents[next]);
                    availableStudents.RemoveAt(next);
                }
                
                groups.Add(new Group(group, students));
            }

            Program.objectManager.Groups = groups;

            Console.WriteLine("Successfully created " + groupAmount + " new groups");

        }

    }
}
