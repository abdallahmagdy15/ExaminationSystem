using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class StudentGrade
    {
        public int ExId { get; set; }
        public string ExDesc { get; set; }
        public int ExDuration { get; set; }
        public DateTime ExDate { get; set; }
        public string CrsName { get; set; }
        public int Grade { get; set; }
        public StudentGrade() { }

        public StudentGrade(string exDesc, int exDuration, DateTime exDate, string crsName, int grade, int exid)
        {
            ExDesc = exDesc;
            ExDuration = exDuration;
            ExDate = exDate;
            CrsName = crsName;
            Grade = grade;
            ExId = exid;
        }
    }
}
