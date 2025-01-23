class Program
{
    public static void Main(String[] args)
    {

        Console.WriteLine(printname("Bhaneshvar"));
        Console.WriteLine("The sum of the number : " + addSum(10, 20));
        printArr();
        stringMethos();

    }


    public static string printname(string name)
    {
        return name;
    }


    public static int addSum(int a, int b)
    {
        return a + b;
    }


    // Iterate the array
    public static void printArr()
    {
        int[] arr = { 10, 20, 30, 40, 50, 60 };

        foreach (var i in arr)
        {
            Console.Write(i + " , ");
        }
    }


    // All String methods in one method

    public static void stringMethos()
    {
        string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The length of the txt string is: " + txt1.Length);


        string txt2 = "Hello World !!";
        Console.WriteLine(txt2.ToUpper());
        Console.WriteLine(txt2.ToLower());


        string firstName = "John ";
        string lastName = "Doe";
        // string name = firstName + lastName; // Concat the string
        string name = string.Concat(firstName, lastName);
        Console.WriteLine(name);
        string str = "Abhishek";
        int index = str.LastIndexOf('h'); // Return the last index of the character (Jo character hamen choose kiya hai uska last index return karta hai )
        Console.WriteLine("The last index of the character is  : " + index);


        // Compare method -> if Compare to string is equal are not
        string str1 = "C#";
        string str2 = "C#";
        string str3 = "Programiz";
        int result;
        // compares str1 with str2
        result = String.Compare(str1, str2);
        Console.WriteLine(result);
        //compares str1 with str3
        result = String.Compare(str1, str3);
        Console.WriteLine(result);
        //compares str3 with str1
        result = String.Compare(str3, str1);
        Console.WriteLine(result);
        // String.Compare(str1, str2) returns 0 since str1 and str2 are equal
        // String.Compare(str1, str3) returns -1 since str1 comes before str3
        // String.Compare(str3, str1) returns 1 since str3 comes after str1



        // The Contains() method checks whether the specified string is present in the string or not.
        string cont = "I love ice cream";
        // check if str contains "ice cream"
        bool check = cont.Contains("ice cream");
        Console.WriteLine(check);


        // creates a string array.
        string[] joinvar = { "C#", "program", "join", "method" };
        // joins string with space between them
        Console.WriteLine(String.Join(" ", joinvar));



        string Index_ = "This is an index of";
        // returns index of substring cream
        int indexOfResult = Index_.IndexOf("index");
        Console.WriteLine(indexOfResult);


        string trime = "    Ice cream   ";
        // trims leading and trailing whitespaces 
        string trimRes = trime.Trim();
        Console.WriteLine(trimRes);



        // The String Equals() method checks whether two strings have the same value or not.
        string stra = "Ice cream";
        string strb = "Ice cream";
        // comparing str1 with str2
        bool eqResult = String.Equals(stra, strb);
        Console.WriteLine(eqResult);


        // The Substring() method returns a substring from the given string.

        string substr = "this is an example of the substring";
        Console.WriteLine(substr.Substring(6, 11));



        // The Split() method breaks up a string at the specified separator and returns its substrings.
        string splttext = "C# is a fun programming language";
        // split string 
        string[] spltResult = splttext.Split(" ");
        Console.Write("Result: ");
        foreach (String s in spltResult)
        {
            Console.WriteLine(s + ", ");
        }

    }
}