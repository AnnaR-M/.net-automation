using Homework4.Extensions;
using Homework4.Methods;
using Homework4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Applications
{
    public class Application
    {
        public void Run()
        {
            var testcaseList = new List<TestCase>();
            var bugList = new List<Bug>();

            while (true)
            {
                var choice = Actions.ChooseOption(
                                        "Create a test case",
                                        "Show a test case by id",
                                        "Show all test cases",
                                        "Delete test case by id",
                                        "Show all bugs",
                                        "Delete a bug",
                                        "Exit");
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
                        testcaseList.ShowIssueById(choice);                            
                        break;
                    case 3:
                        Console.WriteLine("Show testcase by id: ");
                        testcaseList.ShowAll(); 
                        break;
                    case 4:
                        Console.WriteLine("Fill bug: ");
                        testcaseList.DeleteIssueById(choice);
                        break;
                    case 5:
                        Console.WriteLine("Show bug by id: ");
                        bugList.ShowIssueById(choice);
                        break;
                    case 6:
                        Console.WriteLine("Show bug: ");
                        bugList.ShowAll();
                        break;                
                    case 7:
                        Console.WriteLine("Show bug by id: ");
                        bugList.DeleteIssueById(choice);
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            }
        }
    }
}
