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




// // class Program
// {
//     public static void Main(string[] args)
//     {
//         // Console.Write("Enter any number ");
//         // int num = Convert.ToInt32(Console.ReadLine());

//         // int fact = 1;
//         // for (int i = 2; i <= num; i++)
//         // {
//         //     fact *= i;
//         // }
//         // Console.WriteLine("Result is : " + fact);

//         // Console.WriteLine("for Palindrome number ");
//         // Console.Write("Enter any number : ");
//         // int n = Convert.ToInt32(Console.ReadLine());

//         // int temp = n;

//         // int rev  = 0;

//         // while(n!=0){
//         //     int rem = n %10;
//         //     rev = rev * 10 + rem;
//         //     n = n / 10;
//         // }

//         // if(rev == temp) Console.WriteLine("True");
//         // else Console.WriteLine("False");



//         // Console.Write("Armstrong number : ");
//         // int n1 = Convert.ToInt32(Console.ReadLine());

//         // int len = 0;
//         // int temp1 = n1;

//         // while (n1 != 0)
//         // {
//         //     n1 = n1 / 10;
//         //     len++;
//         // }
//         // n1 = temp1;
//         // int res = 0;

//         // while (n1 != 0)
//         // {
//         //     int arm = n1 % 10;
//         //     int pow = 1;

//         //     for (int i = 0; i < len; i++)
//         //     {
//         //         pow *= arm;
//         //     }

//         //     res += pow;
//         //     n1 = n1 / 10;
//         // }

//         // if (res == temp1) Console.WriteLine("Armstrong number ");
//         // else Console.WriteLine("Not a Armstrong number ");

//     }
// }