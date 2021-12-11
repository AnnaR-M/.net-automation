using Homework3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public class TestCase : Issue
    {
        public TestCase()
        {

        }
        public TestCase(string creationDate, Priority priority, string summary, string precondition, Status status) :
            base(creationDate, priority, summary, precondition, status)
        {
        }

        public override string Get()
        {
            return string.Concat(base.Get());
        }

        public override void Set()
        {
            base.Set();
        }

        public override void ChoosePriority()
        {
            base.ChoosePriority();
        }

        public override void ChooseStatus()
        {
            base.ChooseStatus();
        }
    }
}
