using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Step
    {
        private Guid number;

        private string action;

        private string result;

        public Guid Number
        {
            get { return number; }
            set {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else
                    number = value; }
        }
        public string Action
        {
            get { return action; }
            set {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else
                    action = value; }
        }
        public string Result
        {
            get { return result; }
            set {
                if (value == null)
                    Console.WriteLine("Please enter again");
                else 
                result = value; 
            }
        }
        public Step(string action, string result)
        {
            this.action = action;
            this.result = result;
        }
        public Step()
        {

        }
        public void FillNumber()
        {
            number = Guid.NewGuid();
        }

        public void ShowNumber()
        {
            Console.WriteLine(Number);

        }
        public void FillAction()
        {
            action = Console.ReadLine();
        }

        public void ShowAction()
        {
            Console.WriteLine(Action);
        }

        public void FillResult()
        {
            result = Console.ReadLine();
        }

        public void ShowResult()
        {
            Console.WriteLine(Result);
        }

        public void ShowStep()
        {
            Console.WriteLine($"number:  {number}; action {action}; result {result}");
        }
    }


}
