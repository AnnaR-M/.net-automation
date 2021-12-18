using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class Step
    {
        int Number { get; }

        string Action { get; set; }

        string Result { get; set; }

        public Step(string action, string result)
        {
            Action = action;
            Result = result;
        }
        public Step()
        {

        }

        public void Set(string Action, string Result)
        {
            Action = Console.ReadLine();
            Result = Console.ReadLine();
        }
    }
}
