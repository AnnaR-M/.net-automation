using Homework3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void AddIssue<T>(this ICollection<T> issueList)
            where T : IIssue, new()
        {
            var issue = new T();

            issue.Set();

            issueList.Add(issue);
        }
        public static void ShowIssue<T>(this ICollection<T> issueList)
            where T : IIssue
        {
            foreach (var issue in issueList)
            {
                Console.WriteLine(issue.Get());
            }
        }

        public static void ShowElement<T>(this ICollection<T> issueList, int id)
           where T : IIssue
        {
            foreach (var issue in issueList)
            {
                Console.WriteLine(issue.Id);
            }
        }
    }
}
