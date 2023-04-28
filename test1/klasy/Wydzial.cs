using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.klasy
{
    internal class Wydzial
    {
        public List<Student> students { get; set; }
    
        public Wydzial(List<Student> listaStudentow) 
        { 
            this.students = listaStudentow;
        }

        public void sprawdzIPoprawDaneLog(int indexOfStudent)
        {
            Random rand = new Random();
            for(int i = 0; i < students.Count; i++)
            {
                if (i == indexOfStudent) continue;
                if (students[i].Equals(students[indexOfStudent])) 
                {
                    students[i].zmienLogin((students[i].pokazLogin() + rand.Next(0, 1000)), students[i].pokazLogin());
                }
            }
        }
    }
}
