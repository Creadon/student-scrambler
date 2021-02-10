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

        public string Usage
        {
            get; private set;
        }

        public Command(string Name, string Description, string Usage)
        {
            this.Name = Name;
            this.Description = Description;
            this.Usage = Usage;
        }

        public abstract void Run(string[] Arguments);

    }
}
