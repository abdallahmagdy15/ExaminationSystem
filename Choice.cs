using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Choice
    {
        public int Id { get; set; }
        string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value.Replace("\r\n", String.Empty);
            }
        }
    }
}
