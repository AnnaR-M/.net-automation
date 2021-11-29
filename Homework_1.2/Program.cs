using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._2
{
    internal class Program
    {

        int id;
        DateTime CreationDate;
        string Summary;
        string Precondition;
        int TestCaseId;
        int StepNumber;
        string ActualResult;
        string ExpectedResult;
        static void Main(string[] args)
        {
                   

            Console.WriteLine("Choose an action: \n" +
                    "1. Id \n" +
                    "2. CreationDate \n" +
                    "3. Summary \n" +
                    "4. Precondition \n" +
                    "5. TestCaseId \n" +
                    "6. StepNumber \n" +
                    "7. ActualResult \n" +
                    "8. ExpectedResult \n" +
                    "9. Choise Priority \n" +
                    "10. Choise Status \n"
                    );
                var choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FillId();
                        ReadId();
                        break;
                    case 2:
                        FillCreationDate();
                        ReadCreationDate();
                        break;
                    case 3:
                        FillSummary();
                        ReadSummary();
                        break;
                    case 4:
                        FillPrecondition();
                        ReadPrecondition();
                        break;
                    case 5:
                        FillStepNumber();
                        ReadStepNumber();
                        break;
                    case 6:
                        FillTestCaseId();
                        ReadTestCaseId();
                        break;
                    case 7:
                        FillActualResult();
                        ReadActualResult();
                        break;
                    case 8:
                        FillExpectedResult();
                        ReadExpectedResult();
                        break;
                    case 9:
                        choisePriority();
                        break;
                    case 10:
                        choiseStatus();
                        break;
                    default:
                        break;
                }
            }


            public static void FillId()
            {
                Console.WriteLine($"Enter Id");
                var id = Console.ReadLine();
            }

            public static void ReadId()
            {
                var id = Console.ReadLine();
                Console.WriteLine($"Id: {id}");
            }
            public static void FillCreationDate()
            {
                Console.WriteLine($"Enter creationDate");
                var creationDate = Console.ReadLine();
            }
            public static void ReadCreationDate()
            {
                var creationDate = Console.ReadLine();
                Console.WriteLine($"CreationDate: {creationDate}");
            }

            public static void FillSummary()
            {
                Console.WriteLine($"Enter summary");
                var summary = Console.ReadLine();
            }
            public static void ReadSummary()
            {
                var summary = Console.ReadLine();
                Console.WriteLine($"Summary: {summary}");
            }

            public static void FillPrecondition()
            {
                Console.WriteLine($"Enter precondition");
                var precondition = Console.ReadLine();
            }
            public static void ReadPrecondition()
            {
                var precondition = Console.ReadLine();
                Console.WriteLine($"Precondition: {precondition}");
            }
            public static void FillStepNumber()
            {
                Console.WriteLine($"Enter stepNumber");
                var stepNumber = Console.ReadLine();
            }
            public static void ReadStepNumber()
            {
                var stepNumber = Console.ReadLine();
                Console.WriteLine($"StepNumber: {stepNumber}");
            }

            public static void FillTestCaseId()
            {
                Console.WriteLine($"Enter testCaseId");
                var testCaseId = Console.ReadLine();
            }
            public static void ReadTestCaseId()
            {
                var testCaseId = Console.ReadLine();
                Console.WriteLine($"TestCaseId: {testCaseId}");
            }
            public static void FillActualResult()
            {
                Console.WriteLine($"Enter actualResult");
                var actualResult = Console.ReadLine();
            }
            public static void ReadActualResult()
            {
                var actualResult = Console.ReadLine();
                Console.WriteLine($"ActualResult: {actualResult}");
            }

            public static void FillExpectedResult()
            {
                Console.WriteLine($"Enter expectedResult");
                var expectedResult = Console.ReadLine();
            }
            public static void ReadExpectedResult()
            {
                var expectedResult = Console.ReadLine();
                Console.WriteLine($"expectedResult: {expectedResult}");
            }


        enum Priority : int
        {
            Low = 1,
            Medium = 2,
            High = 3,
        }

        public static void choisePriority()
        {
            var priority = int.Parse(Console.ReadLine());
            switch (priority)
            {
                case 1:
                    priority = (int)Priority.Low;
                    Console.WriteLine($"Low Priority");
                    break;
                case 2:
                    priority = (int)Priority.Medium;
                    Console.WriteLine($"Low Medium");
                    break;
                case 3:
                    priority = (int)Priority.High;
                    Console.WriteLine($"Low High");
                    break;
                default:
                    break;
            }
        }

        enum Status
        {
            New,
            InProgress,
            Failed,
            Done
        }


        public static void choiseStatus()
        {
            var status = int.Parse(Console.ReadLine());
            switch (status)
            {
                case 1:
                    status = (int)Status.New;
                    Console.WriteLine($"New Status");
                    break;
                case 2:
                    status = (int)Status.InProgress;
                    Console.WriteLine($"New Status");
                    break;
                case 3:
                    status = (int)Status.Failed;
                    Console.WriteLine($"New In Progress");
                    break;
                case 4:
                    status = (int)Status.Done;
                    Console.WriteLine($"New Done");
                    break;
                default:
                    break;

            }
        }

    }
}

