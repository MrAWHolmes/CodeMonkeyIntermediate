using System.Runtime.InteropServices;

namespace CMB_Arrays_Lists_02h40
/*
 * Ref: CodeMonkey-Beginner-Arrays,Lists-02h49
 * youtube : https://youtu.be/qZpMX8Re_2Q?t=9646
 * 
 * Ref2 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generics-and-arrays
 * 
 */
{

    // cant declare variable here ! not even static!
    // :( static int[] GlobalArray;


    internal class Program
    {
        //Arrays once defined 'have a fixed size'
        static int[] Array1;                           // an int array - equivalent to Array1 = {};
        static int[] Array2 = { 56, 123, 12 };         // initialise to have 3 values
        static int[] Array3 = new int[] { 4, 2, 43 };  // more explicit
        static int[] ArraySize5 = new int[5];          // = {0,0,0,0,0};

        //List declarations - this uses <generics>
        static List<int> List1 = new List<int> { 1, 2, 3, 4 };
        static List<int> List2 = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Array 'Array2'");
            showArray(Array2);
            Console.WriteLine();

            Console.WriteLine("Array 'Array5'");
            showArray(ArraySize5);
            Console.WriteLine();

            Console.WriteLine($"System.Array.IndexOf(Array5,2) -->{System.Array.IndexOf(ArraySize5,2)}");


            Console.WriteLine("List 'List1'");
            showList<int>(List1);
            Console.WriteLine();

            Console.WriteLine("List 'List1 after.Add(100);'");
            List1.Add(100);
            showList<int>(List1);
            Console.WriteLine();

            Console.WriteLine($"List1.IndexOf(100) --> {List1.IndexOf(100)}");

            Console.WriteLine();

            Console.WriteLine("List 'List2'");
            showList<int>(List2);
            Console.WriteLine();


            Console.ReadKey();       }

        public static void showArray(int[] array)
        {
            string s = "{";
            foreach (int t in array)
            {
                s += $"{t},";
            }

            //debug print!
            //Console.WriteLine($"s.Length-1 = {s.Length - 1}");
            //Console.WriteLine($"s.Substring(0,Length-1)) = {s.Substring(0,s.Length - 1)}");

            //drop trailing ,
            s = s.Substring(0, s.Length - 1);

            
            s += "}";
            Console.Write(s);
        }

        public static void showList<T>(IList<T> list)
        { // Lists use .Count instead of .Length
            string s = "{";
            foreach (T t in list)
            {
                s += $"{t},";
            }



            //debug print!
            //Console.WriteLine($"s.Length-1 = {s.Length - 1}");
            //Console.WriteLine($"s.Substring(0,Length-1)) = {s.Substring(0, s.Length - 1)}");

            //drop trailing ,
            if (s.Length > 2) s = s.Substring(0, s.Length - 1); // only remove , if it exists
            

            s += "}";
            Console.Write(s);
        }
    }
}
