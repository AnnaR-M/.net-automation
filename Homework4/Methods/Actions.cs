using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Methods
{
    public static class Actions
    {
        public static int ChooseOption(string title, params string[] options)
        {
            int choice;
            while (true)
            {
                Console.Clear();
                ShowOptions(title, options);
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Length)
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

        public static int ChooseEnumOptions<T>()
            where T : Enum
        {
            var str = new List<string>();
            foreach (var option in Enum.GetValues(typeof(T)))
            {
                str.Add(option.ToString());
            }

            return ChooseOption(str.ToArray());
        }

        private static int ChooseOption(string[] vs)
        {
            throw new NotImplementedException();
        }

        private static void ShowOptions(string title, params string[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }
    }
}



