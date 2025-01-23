class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name : ");


        string name = Console.ReadLine();
        string temp = "";
        for (int i = 0; i < name.Length; i++)
        {
            if (i == 0 || i == name.Length - 1) temp += Char.ToUpper(name[i]);

            else temp += name[i];
        }
        Console.WriteLine(temp);





        // Hologram Pettern 
        Console.Write("Enter any number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    Console.Write("* ");

                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();



        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        Console.WriteLine();


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || i == n - 1)
                    Console.Write("* ");

                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }


        Console.WriteLine();


    }
}