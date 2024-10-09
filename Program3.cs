namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string cumle = "otuz bes dene qaz var satdiq";
            string a= herf(cumle);
            Console.WriteLine(a);   
            
        } static string herf(string s) {
            string bosluqsuz = " ";
            for (int i = 0; i < s.Length; i++)
            { 
                if (s[i] != ' ')
                {
                    bosluqsuz += s[i];
                }
                

                
            } return bosluqsuz;
        }
    }
}
