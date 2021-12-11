using Homework3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{

    public class Bug : Issue
    {
        public Bug()
        {
        }

        public Bug(string creationDate, Priority priority, string summary, string precondition, Status status) :
            base(creationDate, priority, summary, precondition, status)
        {
        }

        public int TestCaseId { get; set; }

        public int StepNumber { get; set; }

        public override string Get()
        {
            return string.Concat(base.Get(), "\nTestCaseId: ", TestCaseId, "\nStepNumber: ", StepNumber);
        }

        public override void Set()
        {
            int testCaseId;
            int stepNumber;
            base.Set();
            while (true)
            {
                Console.Write("Enter the stepNumber: ");
                if (int.TryParse(Console.ReadLine(), out testCaseId))
                {
                    TestCaseId = testCaseId;
                    return;
                }
                if (int.TryParse(Console.ReadLine(), out stepNumber))
                {
                    StepNumber = stepNumber;
                    return;
                }
            }
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
