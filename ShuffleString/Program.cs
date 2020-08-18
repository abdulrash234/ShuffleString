using System;

namespace ShuffleString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] indices = {4, 5, 6, 7, 0, 2, 1, 3};
            Console.WriteLine(RestoreString("codeleet", indices));
        }

        public static string RestoreString(string s, int[] indices)
        {

            var arrayShuffled = new char[indices.Length];
            var returnedString = "";
            var i = 0;
            foreach (var letter in s)
            {
                arrayShuffled[indices[i]] = letter;
                i++;
            }


            foreach (var c in arrayShuffled)
            {
                returnedString = returnedString + c;
            }

            return returnedString;
        }
    }
}
