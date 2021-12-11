using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Methods
{
    public static class Actions
    {
        public static int ChooseOption(params string[] paramList)
        {
            int choice;
            while (true)
            {
                Console.Clear();
                ShowOptions(paramList);
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > paramList.Length)
                    {
                        throw new InvalidInputException();
                    }
                    return choice - 1;
                }
                catch (InvalidInputException ex)
                {
                    ex.ShowMessage();
                }
            }
        }

        private static void ShowOptions(params string[] paramList)
        {
            for (int i = 0; i < paramList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {paramList[i]}");
            }
        }
    }
}
