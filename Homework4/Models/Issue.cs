using Homework4.Enums;
using Homework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public abstract class Issue : IIssue

    {
        private static long id = 0;

        public Issue()
        {

        }

        public Issue(DateTime creationDate, Status status)
        {
            Id = ++id;
            CreationDate = creationDate;
            Status = Status.New;
        }

        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime CreationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Priority Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Summary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Precondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Fill()
        {
            Console.Write("Enter the CreationDate: ");
            CreationDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the Summary: ");
            Summary = Console.ReadLine();

            Console.Write("Enter the Precondition: ");
            Precondition = Console.ReadLine();
        }

        public virtual string Show()
        {
            return string.Concat($"Id: {Id}", $"\nCreationDate:   {CreationDate}", $"\nPriority:   {Priority}",
                $"\nSummary:  {Summary}", $"\nPrecondition:   {Precondition}", $"\nStatus:   {Status}");
        }
    }
}
