using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class Bug : Issue
    {
        public Bug()
        {
        }
        public Bug(DateTime creationDate, Status status) : base(creationDate, status)
        {
        }

        long? TestCaseId { get; set; }

        int? StepNumber { get; set; }

        string ActualResult { get; set; }

        string ExpectedResult { get; set; }

        public Bug(long? testCaseId, int? stepNumber, string actualResult, string expectedResult)
        {
            TestCaseId = testCaseId;
            StepNumber = stepNumber;
            ActualResult = actualResult;
            ExpectedResult = expectedResult;
        }

        public override string Show()
        {
            return string.Concat(base.Show(), "\nTestCaseId: ", TestCaseId, "\nStepNumber: ", StepNumber,
                "\nActualResult: ", ActualResult, "\nExpectedResult: ", ExpectedResult);
        }

        public override void Fill()
        {
            base.Fill();
            Console.Write("Enter the testCaseId: ");
            TestCaseId = int.Parse(Console.ReadLine());

            Console.Write("Enter the stepNumber: ");
            StepNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the actualResult: ");
            ActualResult = Console.ReadLine();
        }
    }
}



