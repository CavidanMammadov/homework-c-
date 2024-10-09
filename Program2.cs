using System.Globalization;

namespace homework2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "  otuz bes dene qaz var satdiq";
            string a = FirstLetters(cumle);
            Console.Write(a);
        }
        static string FirstLetters( string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    Console.Writeline(s[i+1]);
                }
            }
            return s;   
        }
    }
}
