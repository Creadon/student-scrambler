using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    class Question
    {

        public int Id
        {
            get; private set;
        }

        public string Query
        {
            get; private set;
        }

        public List<Student> Students
        {
            get; private set;
        }

        public Question(int Id, string Query, List<Student> Students)
        {
            this.Id = Id;
            this.Query = Query;
            this.Students = Students;
        }

    }
}
