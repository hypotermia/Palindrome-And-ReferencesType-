using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============== Choose One ==============");
            Console.WriteLine("1. ReferencesType and Value Type Examples  ");
            Console.WriteLine("2. Palindrome Check   ");
            Console.WriteLine("Choose one (1/2) : ");
            int chooser = int.Parse(Console.ReadLine());
            if(chooser == 1)
            {
                ReferencesAndValue();
            }
            else if (chooser ==2)
            {
                Console.Write("Masukkan sebuah string: ");
                string userInput = Console.ReadLine();
                bool isPalindrome = IsPalindrome(userInput);
                Console.WriteLine(isPalindrome);
            }
            else
            {
                Console.WriteLine("Wrong Input Please Choose 1 or 2 ");
            }
        }

        static bool IsPalindrome(string s)
        {
            string cleanedString = s.Replace(" ", "").ToLower();
            int length = cleanedString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedString[i] != cleanedString[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void ReferencesAndValue()
        {
            // Value Type Example
            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine("Contoh Value Type:");
            Console.WriteLine($"a = {a}, b = {b}");
            //Ketika b diubah, nilai a tetap sama karena int adalah Value Type.
            Console.WriteLine("Ketika b diubah, nilai a tetap sama karena int adalah Value Type.");

            // Reference Type Example
            MyClass obj1 = new MyClass();
            obj1.Value = 5;
            MyClass obj2 = obj1;
            obj2.Value = 10;
            Console.WriteLine("Contoh Reference Type:");
            Console.WriteLine($"obj1.Value = {obj1.Value}, obj2.Value = {obj2.Value}");
            //Ketika obj2 diubah, nilai obj1 juga berubah karena MyClass adalah Reference Type.
            Console.WriteLine("Ketika obj2 diubah, nilai obj1 juga berubah karena MyClass adalah Reference Type.");



            //Value Type menyimpan nilai secara langsung di dalam memori stack.
            //Reference Type menyimpan referensi ke nilai yang disimpan di dalam memori heap.
            //"Contoh Value Type: int, float, bool, struct.
            //"Contoh Reference Type: class, array, string.
        }
    }

    class MyClass
    {
        public int Value { get; set; }
    }
}

