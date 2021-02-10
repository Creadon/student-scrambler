using System;

namespace student_scrambler.Commands
{
    class AddCommand : Command
    {

        public AddCommand() : base("Add", "Add new student")
        { }

        public override void Run(string[] Arguments)
        {
            Program.objectManager.CreateNewStudent(Arguments[1]);
        }
    }
}
