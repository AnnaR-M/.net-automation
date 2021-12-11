using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Interfaces
{
    public interface IIssue
    {
        int Id { get; }
        void ChoosePriority();
        string Get();
        void Set();

    }
}
