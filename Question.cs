using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Question
    {
        public int Id { get; set; }
        public  string Content { get; set; }
        public int Grade { get; set; }
        public bool Type { get; set; }
        public List<Choice> Choices { get; set; }
        public Choice Answer { get; set; }
        public Question()
        {
            Choices = new List<Choice>();
        }

    }
}
