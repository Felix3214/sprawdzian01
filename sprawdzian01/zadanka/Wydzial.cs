using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian01.zadanka
{
    public class Wydzial
    {
        public List<Student> studenci;

        public Wydzial()
        {
            this.studenci = new List<Student>();
        }

        public IEnumerable<object> Studenci { get; internal set; }

        public void DodajStudenta(Student student)
        {
            this.studenci.Add(student);
        }

        public void WypiszStudentow()
        {
            foreach (var student in this.studenci)
            {
                Console.WriteLine(student.ToString());
            }
        }

        
    }
}



