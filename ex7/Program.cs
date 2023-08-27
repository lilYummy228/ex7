using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите кол-во повторений: ");
            int repetitionsOfText = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repetitionsOfText; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
