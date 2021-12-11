using Homework3.Extensions;
using Homework3.Methods;
using Homework3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{

    class Program
    {
        static void Main(string[] args)
        {
            var testcaseList = new List<TestCase>();
            var bugList = new List<Bug>();

            while (true)
            {
                var choice = Actions.ChooseOption(
                    "Add test case",
                    "Show all test case",
                    "Report bug",
                    "Show all bugs");
                Console.WriteLine(choice);
                if (choice == 3)
                {
                    return;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Fill  testcase: ");
                        testcaseList.AddIssue();
                        break;
                    case 2:
                        Console.WriteLine("Show testcase: ");
                        testcaseList.ShowIssue();
                        break;
                    case 3:
                        Console.WriteLine("Show testcase by id: ");
                        testcaseList.ShowElement(choice);
                        break;
                    case 4:
                        Console.WriteLine("Fill bug: ");
                        bugList.AddIssue();
                        break;
                    case 5:
                        Console.WriteLine("Show bug: ");
                        bugList.ShowIssue();
                        break;
                    case 6:
                        Console.WriteLine("Show bug by id: ");
                        bugList.ShowElement(choice);
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
        }
    }
}



