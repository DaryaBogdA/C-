using System;





class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");
        string str = Console.ReadLine();
        Console.WriteLine("Enter symbol");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        str_result(str, symbol);
    }

    public static void ex6()
    {
        Console.WriteLine("Enter string");
        string str = Console.ReadLine();
        Console.WriteLine("Enter symbol");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        str_result(str, symbol);
    }

    public static void str_result(string str, char symbol)
    {
        string result = "";
        int last_index = -1;
        for (int i = 0; i < str.Length; i++) 
        { 
            if(str[i] == symbol)
            {
                result += char.ToUpper(symbol);
                last_index = i;
            }
            else
            {
                result += str[i];
            }
            
        }
        result = result.Substring(0, last_index + 1);
        Console.WriteLine(result);
    }

    public static void ex5()
    {
        Console.WriteLine("Enter string");
        string str = Console.ReadLine();
        str_statistic(str);
    }

    public static void str_statistic(string str)
    {
        int len = str.Length;
        int letter = 0;
        int upper = 0;
        int lower = 0;
        int number = 0;
        int punctuation = 0;
        int space = 0;
        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                letter++;
                if (char.IsUpper(c)) upper++;
                if (char.IsLower(c)) lower++;
            }
            else if (char.IsDigit(c))
            {
                number++;
            }
            else if (char.IsPunctuation(c))
            {
                punctuation++;
            }
            else if (char.IsWhiteSpace(c))
            {
                space++;
            }
        }
        Console.WriteLine("Length " + len);
        Console.WriteLine("Count letter " + letter);
        Console.WriteLine("Count in upper " + upper);
        Console.WriteLine("Count in lower " + lower);
        Console.WriteLine("Count numbers " + number);
        Console.WriteLine("Count punctuation " + punctuation);
        Console.WriteLine("Count space " + space);

    }

    public static void ex4()
    {
        int m = 5, n = 5;
        int[,] arr = new int[m, n];
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = random.Next(100);
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-----------------------");
        arr = change_column(arr, 1, 3);
        show(arr);

    }

    public static void show(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] change_column(int[,] arr, int first_column, int second_column)
    {
        int rows = arr.GetLength(0);

        for (int i = 0; i < rows; i++)
        {
            int temp = arr[i, first_column];
            arr[i, first_column] = arr[i, second_column];
            arr[i, second_column] = temp;
        }
        return arr;
    }

    public static void ex3()
    {
        int[] arr = { 3, 0, -6, 0, -23, -90, 0, -7, 9, 0, 5 };
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        foreach (int i in arr)
        {
            if (i == number) count++;
        }
        Console.WriteLine("Number " + number + " count " + count);
    }

    public static void ex2()
    {
        int[] arr = { 3, 0, -6, 0, -23, -90, 0, -7, 9, 0, 5 };
        int[] result = change_negative_and_positive(arr);

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] change_negative_and_positive(int[] arr)
    {
        int[] result = new int[arr.Length];
        int index = 0;
        foreach (int i in arr)
        {
            if (i < 0)
            {
                result[index++] = i;
            }
        }

        foreach (int i in arr)
        {
            if (i >= 0)
            {
                result[index++] = i;
            }
        }
        return result;
    }


    public static void ex1()
    {
        int[] arr = { 3, 0, 6, 0, 23, 90, 0, 7, 9, 0, 5 };

        int[] result = remove_0(arr);

        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] remove_0(int[] arr)
    {
        int[] result = new int[arr.Length];
        int index = 0;

        foreach (int num in arr)
        {
            if (num != 0)
            {
                result[index++] = num;
            }
        }

        for (int i = index; i < result.Length; i++)
        {
            result[i] = -1;
        }

        return result;
    }
}


class Student
{
    public string latname;
    public string name;
    public string surname;
    public string group;
    public int age;
    private int[][] grades;

    public Student(string lastName, string name, string surname, string group, int age)
    {
        this.latname = lastName;
        this.name = name;
        this.surname = surname;
        this.group = group;
        this.age = age;

        grades = new int[3][];
        grades[0] = new int[0];
        grades[1] = new int[0];
        grades[2] = new int[0];
    }

    public void add_grade(string subject, int grade)
    {
        int index = get_subject(subject);
        if (index == -1)
        {
            Console.WriteLine("No predmet");
            return;
        }

        int[] new_grade = new int[grades[index].Length + 1];
        for (int i = 0; i < grades[index].Length; i++)
        {
            new_grade[i] = grades[index][i];
        }
        new_grade[new_grade.Length - 1] = grade;
        grades[index] = new_grade;
    }

    public int[] get_grade(string subject)
    {
        int index = get_subject(subject);
        return index == -1 ? new int[0] : grades[index];
    }

    public double get_average(string subject)
    {
        int index = get_subject(subject);
        if (index == -1 || grades[index].Length == 0)
            return 0;

        return grades[index].Average();
    }

    public void show_info()
    {
        Console.WriteLine($"Student: {latname} {name} {surname}");
        Console.WriteLine($"Group: {group}, Age: {age}");
        Console.WriteLine("Оценки:");
        Console.WriteLine($"Progtamming: {string.Join(", ", grades[0])}");
        Console.WriteLine($"Administration: {string.Join(", ", grades[1])}");
        Console.WriteLine($"Disigh: {string.Join(", ", grades[2])}");
    }

    private int get_subject(string subject)
    {
        switch (subject.ToLower())
        {
            case "progtamming":
                return 0;
            case "administration":
                return 1;
            case "disigh":
                return 2;
            default:
                return -1;
        }
    }
}