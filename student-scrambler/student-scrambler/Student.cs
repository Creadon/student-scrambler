using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    class Student
    {

        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

    }
}
