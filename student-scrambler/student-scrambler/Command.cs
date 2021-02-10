using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    abstract class Command
    {

        public string Name
        {
            get; private set;
        }

        public string Description
        {
            get; private set;
        }

        public Command(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public abstract void Run(string[] Arguments);

    }
}
