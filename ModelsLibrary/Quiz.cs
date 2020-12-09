using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class Quiz
    {
        public string Name { get; set; }
        public List<string> Questons { get; set; } = new List<string>();

        public double Score { get; set; }
        public DateTime time { get; set; }
    }
}
