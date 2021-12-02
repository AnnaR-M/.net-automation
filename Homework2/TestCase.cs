using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class TestCase
    {
        private Guid id;

        private Guid creationDate;

        Priority priority;

        private string summary;

        private string precondition;

        Status status;

        public Guid Id
        {
            get { return id; }
            set
            {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else
                    id = value;
            }
        }
        public Guid CreationDate
        {
            get { return creationDate; }
            set
            {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else creationDate = value;
            }
        }

        public Priority Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string Summary
        {
            get { return summary; }
            set
            {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else
                    summary = value;
            }
        }

        public string Precondition
        {
            get { return precondition; }
            set
            {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else
                    precondition = value;
            }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public void FillId()
        {
            id = Guid.NewGuid();
        }

        public void ShowId()
        {
            Console.WriteLine(Id);
        }
        public void FillCreationDate()
        {
            creationDate = Guid.NewGuid();
        }

        public void ShowCreationDate()
        {
            Console.WriteLine(CreationDate);
        }

        public void FillPriority()
        {
            Console.WriteLine("Choose priority's type: \n" +
                "1. Low - 1 \n" +
                "2. Medium - 2 \n" +
                "3. High - 3 \n");
            var priority = int.Parse(Console.ReadLine());

            switch (priority)
            {
                case 1:
                    Console.WriteLine(Priority.Low);
                    break;
                case 2:
                    Console.WriteLine(Priority.Medium);
                    break;
                case 3:
                    Console.WriteLine(Priority.High);
                    break;
                default:
                    break;
            }

        }

        public void ShowPriority()
        {
            Console.WriteLine(Priority);
        }

        public void FillSummary()
        {
            Summary = Console.ReadLine();
        }

        public void ShowSummary()
        {
            Console.WriteLine(Summary);
        }


        public void FillPrecondition()
        {
            Precondition = Console.ReadLine();
        }

        public void ShowPrecondition()
        {
            Console.WriteLine(Precondition);
        }

        public void FillStatus()
        {
            Console.WriteLine("Choose status's type: \n" +
                "1. New - 1 \n" +
                "2. InProgress - 2 \n" +
                "3. Failed - 3 \n" +
                "4. Done - 4");
            var status = int.Parse(Console.ReadLine());

            switch (status)
            {
                case 1:
                    Console.WriteLine(Status.New);
                    break;
                case 2:
                    Console.WriteLine(Status.InProgress);
                    break;
                case 3:
                    Console.WriteLine(Status.Failed);
                    break;
                case 4:
                    Console.WriteLine(Status.Done);
                    break;
                default:
                    break;
            }

        }

        public void ShowStatus()
        {
            Console.WriteLine(Status);
        }

        public void ShowTestCase()
        {
            Console.WriteLine($"id:  {id}; creationdate {creationDate}; priority {priority}; summary {summary};" +
                $" precondition {precondition}; status {status}");
        }
    }
}
