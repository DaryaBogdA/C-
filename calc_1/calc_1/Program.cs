using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int first_number, second_number;
            show_text("Enter first number");
            first_number = number();
            show_text("Enter second number");
            second_number = number();
            show_text("Enter operation");
            Console.WriteLine(operation(first_number, second_number));
            show_text("Exit ?");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
            {
                break;
            }
        }
       
    }

    static void show_text(string text)
    {
        Console.WriteLine(text);
    }
    static int number()
    {
        int result;
        while (true)
        {
            string number = Console.ReadLine();
            if (int.TryParse(number, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Not number");
            }
        }
    }
    static int operation(int num_1, int num_2)
    {
        
        while (true)
        {
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "+":
                    return num_1 + num_2;
                case "-":
                    return num_1 - num_2;
                case "*":
                    return num_1 * num_2;
                case "/":
                    return num_1 / num_2;
                default:
                    Console.WriteLine("No find operation");
                    break;
            }
        }
        
    }
}
