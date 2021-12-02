using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var step = new Step();
            var testCase = new TestCase();
            var bug = new Bug();

            Console.WriteLine("Please enter action's number: \n" +
                "\n" +
                "If you want to work with Step: \n" +
                "1. to fill Action - 1 \n" +
                "2. to fill Result - 2 \n" +
                "3. to show Step - 3 \n" +
                "\n" +
                "If you want to work with Testcase: \n" +
                "4. to choose Priority: Low, Medium, High - 4 \n" +
                "5. to fill Summary - 5\n" +
                "6. to fill Precondition - 6 \n" +
                "7. to choose Status: New, InProgress, Failed, Done - 7 \n" +
                "8. to show Testcase - 8 \n" +
                "\n" +
                "If you want to work with Bug: \n" +
                "9. to fill  Id - 9 \n" +
                "10. to fill  CreationDate - 10 \n" +
                "11. to choose Priority: Low, Medium, High - 11 \n" +
                "12. to fill  Summary - 12 \n" +
                "13. to fill  Precondition - 13 \n" +
                "14. to choose Status: New, InProgress, Failed, Done - 14 \n" +
                "15. to fill  TestCaseId - 15 \n" +
                "16. to fill  StepNumber - 16\n" +
                "17. to fill  ActualResult - 17 \n" +
                "18. to fill  ExpectedResult - 18 \n" +
                "19. to show Bug - 19 \n");

            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter action: ");
                    step.FillAction();
                    step.ShowAction();
                    break;
                case 2:
                    Console.WriteLine("Enter action: ");
                    Console.WriteLine("Enter  result: ");
                    step.FillResult();
                    step.ShowResult();
                    break;
                case 3:
                    step.ShowStep();
                    break;
                case 4:
                    Console.WriteLine("Choose Priority: Low, Medium, High");
                    testCase.FillPriority();
                    testCase.ShowPriority();
                    break;
                case 5:
                    Console.WriteLine("Enter Summary: ");
                    testCase.FillSummary();
                    testCase.ShowSummary();
                    break;
                case 6:
                    Console.WriteLine("Enter Precondition");
                    testCase.FillPrecondition();
                    testCase.ShowPrecondition();
                    break;
                case 7:
                    Console.WriteLine("Choose Status: New, InProgress, Failed, Done");
                    testCase.FillStatus();
                    testCase.ShowStatus();
                    break;
                case 8:
                    testCase.ShowTestCase();
                    break;
                case 9:
                    Console.WriteLine("Enter Id");
                    bug.FillId();
                    bug.ShowId();
                    break;
                case 10:
                    Console.WriteLine("Enter CreationDate");
                    bug.FillCreationDate();
                    bug.ShowCreationDate();
                    break;
                case 11:
                    Console.WriteLine("Choose Priority: Low, Medium, High");
                    bug.FillPriority();
                    bug.ShowPriority();
                    break;
                case 12:
                    Console.WriteLine("Enter Summary: ");
                    bug.FillSummary();
                    bug.ShowSummary();
                    break;
                case 13:
                    Console.WriteLine("Enter Precondition");
                    bug.FillPrecondition();
                    bug.ShowPrecondition();
                    break;
                case 14:
                    Console.WriteLine("Choose Status: New, InProgress, Failed, Done");
                    bug.FillStatus();
                    bug.ShowStatus();
                    break;
                case 15:
                    Console.WriteLine("Enter TestCaseId");
                    bug.FillTestCaseId();
                    bug.ShowTestCaseId();
                    break;
                case 16:
                    Console.WriteLine("Enter StepNumber");
                    bug.FillStepNumber();
                    bug.ShowStepNumber();
                    break;
                case 17:
                    Console.WriteLine("Enter ActualResult");
                    bug.FillActualResult();
                    bug.ShowActualResult();
                    break;
                case 18:
                    Console.WriteLine("Enter ExpectedResult");
                    bug.FillExpectedResult();
                    bug.ShowExpectedResult();
                    break;
                case 19:
                    bug.ShowBug();
                    break;
                default:
                    Console.WriteLine("Incorrect value");
                    break;

            }
        }
    }
}









