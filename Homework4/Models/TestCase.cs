using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class TestCase : Issue
    {
        public List<Step> Steps { get; set; }

        public TestCase()
        {
        }

        public TestCase(DateTime creationDate, Status status) : base(creationDate, status)
        {
        }

        public TestCase(List<Step> steps)
        {
            Steps = steps;
        }

        public override string Show()
        {
            return string.Concat(base.Show(), "\nSteps: ", Steps);
        }

        public override void Fill()
        {
            base.Fill();
            Console.Write("Enter Steps: ");
            var Steps = Console.ReadLine().Split();
            var list = Steps.ToList();
        }
    }
}


