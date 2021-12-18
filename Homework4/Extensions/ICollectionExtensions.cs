using Homework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Extensions
{
    public static class ICollectionExtensions
    {
        public static void AddIssue<T>(this ICollection<T> issueList)
            where T : IIssue, new()
        {
            var issue = new T();

            issue.Fill();

            issueList.Add(issue);
        }

        public static void ShowAll<T>(this ICollection<T> issueList)
            where T : IIssue
        {
            foreach (var issue in issueList)
            {
                Console.WriteLine(issue.Show());
            }
        }

        public static void ShowIssueById<T>(this ICollection<T> issueList, long id)
           where T : IIssue, new()
        {
            var issue = issueList.SingleOrDefault(i => i.Id == id);
            issue.Show();
        }

        public static void DeleteIssueById<T>(this ICollection<T> issueList, long id)
            where T : IIssue
        {
            foreach (var issue in issueList)
            {
                issueList.Remove(issue);
            }
        }
    }
}
