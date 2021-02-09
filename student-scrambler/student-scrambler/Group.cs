using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    class Group
    {

        public int Id
        {
            get; private set;
        }

        public List<Student> Students
        {
            get; private set;
        }

        public Group(int Id, List<Student> Students)
        {
            this.Id = Id;
            this.Students = Students;
        }

    }
}
