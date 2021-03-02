using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    public class Student
    {
        public int StId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string DeparmentName { get; set; }
        public Student()
        {
                
        }

        public Student(int stId, string fullName, DateTime birthDate, string deparmentName)
        {
            StId = stId;
            FullName = fullName;
            BirthDate = birthDate;
            DeparmentName = deparmentName;
        }
    }
}
