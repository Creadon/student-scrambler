using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    class ObjectManager
    {

        public List<Student> Students
        {
            get; set;
        }

        public List<Group> Groups
        {
            get; set;
        }

        public ObjectManager()
        {
            if (!File.Exists("students.txt"))
                File.WriteAllText("students.txt", string.Empty);

            Students = FetchStudents();
            Groups = new List<Group>();

            
        }

        public void CreateNewStudent(string Name)
        {
            Students.Add(new Student(Students.Count, Name));
            SaveStudents();
        }

        public void DeleteStudent(int Id)
        {
            Student student = GetStudent(Id);
            if(student != null)
                Students.Remove(student);
            SaveStudents();
        }

        public void DeleteStudent(string Name)
        {
            Student student = GetStudent(Name);
            if (student != null)
                Students.Remove(student);
            SaveStudents();
        }

        public void NewStudentIds()
        {
            int id = 0;
            foreach (Student student in Students)
            {
                student.Id = id;
                id++;
            }
        }

        public void SaveStudents()
        {
            NewStudentIds();
            List<string> output = new List<string>();
            foreach(Student student in Students)
            {
                output.Add(student.Id + ":" + student.Name);
            }
            File.WriteAllLines("students.txt", output);
        }

        public List<Student> FetchStudents()
        {
            List<Student> Students = new List<Student>();
            foreach(string StudentString in File.ReadAllLines("students.txt"))
            {
                string[] Arguments = StudentString.Split(':');
                Students.Add(new Student(int.Parse(Arguments[0]), Arguments[1]));
            }
            return Students;
        }

        public Student GetStudent(int Id)
        {
            foreach (Student student in Students)
                if (student.Id == Id) return student;
            return null;
        }

        public Student GetStudent(string Name)
        {
            foreach (Student student in Students)
                if (student.Name.ToLower() == Name.ToLower()) return student;
            return null;
        }


    }
}
