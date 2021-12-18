using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Interfaces
{
    public interface IIssue
    {
        public long Id { get; set; }

        DateTime CreationDate { get; set; }

        Priority Priority { get; set; }

        string Summary { get; set; }

        string Precondition { get; set; }

        Status Status { get; set; }

        void Fill();

        string Show();
    }
}
