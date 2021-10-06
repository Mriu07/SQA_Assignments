using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Calculate();
            Console.ReadKey();

        }

        private void Calculate()
        {
            int length;
            int width;
            int choice;

            length = InputRectangleLength();
            width = InputRectangleWidth();

            Rectangle rectangle = new Rectangle(length, width);

            choiceOptions:

            string userOptions;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Set Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Set Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                userOptions = Console.ReadLine();
                Console.WriteLine();
            }
            while (!(int.TryParse(userOptions, out choice) && (choice > 0 && choice < 9)));



            switch (choice)
            {
                case 1:
                    Console.WriteLine(rectangle.GetRectangleLength());
                    break;
                case 2:
                    rectangle.SetRectangleLength(InputRectangleLength());
                    break;
                case 3:
                    Console.WriteLine(rectangle.GetRectangleWidth());
                    break;
                case 4:
                    rectangle.SetRectangleWidth(InputRectangleWidth());
                    break;
                case 5:
                    Console.WriteLine(rectangle.GetRectanglePerimeter());
                    break;
                case 6:
                    Console.WriteLine(rectangle.GetRectangleArea());
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }

            goto choiceOptions;

        }

        int InputRectangleLength()
        {
            int length;
            bool isContinue = false;
            string userLength;
            do
            {
                Console.Write("Enter Rectangle Length: ");
                userLength = Console.ReadLine();
                isContinue = (int.TryParse(userLength, out length) && (length > 0));
                if (!isContinue)
                {
                    Console.WriteLine("Length must be a positive integer (Greater than zero and ).");
                }
            }
            while (!isContinue);

            return length;
        }

        int InputRectangleWidth()
        {
            int width;
            bool isContinue = false;
            string userWidth;
            do
            {
                Console.Write("Enter Rectangle Width: ");
                userWidth = Console.ReadLine();
                isContinue = (int.TryParse(userWidth, out width) && (width > 0));
                if (!isContinue)
                {
                    Console.WriteLine("Width must be a positive integer (Greater than zero and ).");
                }
            }
            while (!isContinue);

            return width;
        }

    }
}
