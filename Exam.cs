using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Exam
    {
        public int Ex_Id { get; set; }
        public string Ex_Desc { get; set; }
        public int Ex_Duration { get; set; }
        public string Crs_Name { get; set; }

        public List<Question> Questions { get; set; }
        public Exam()
        {
            Questions = new List<Question>();
        }
    }
}
