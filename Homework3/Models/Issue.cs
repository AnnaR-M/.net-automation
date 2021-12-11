using Homework3.Enums;
using Homework3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public abstract class Issue : IIssue

    {
        private static int id = 0;
        public int Id { get; }

        public string CreationDate { get; set; }

        public Priority Priority { get; set; }

        public string Summary { get; set; }
        public string Precondition { get; set; }

        public Status Status { get; set; }

        public Issue()
        {

        }
        public Issue(string creationDate, Priority priority, string summary, string precondition, Status status)
        {
            Id = ++id;
            CreationDate = creationDate;
            Priority = priority;
            Summary = summary;
            Precondition = precondition;
            Status = status;
        }


        public virtual string Get()
        {
            return string.Concat($"Id: {Id}", $"\nCreationDate:   {CreationDate}", $"\nPriority:   {Priority}",
                $"\nSummary:  {Summary}", $"\nPrecondition:   {Precondition}", $"\nStatus:   {Status}");
        }

        public virtual void Set()
        {
            Console.Write("Enter the CreationDate: ");
            CreationDate = Console.ReadLine();
            Console.Write("Enter the Summary: ");
            Summary = Console.ReadLine();
            Console.Write("Enter the Precondition: ");
            Precondition = Console.ReadLine();
        }
        public virtual void ChoosePriority()
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
        public virtual void ChooseStatus()
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
    }
}
