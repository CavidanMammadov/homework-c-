namespace homework.cs;

internal class Program
{
    static void Main(string[] args)
    {
        int[] ededler = { 9, 4, 5, 6, 7 };
        int a = bigNumber(ededler);
        Console.WriteLine(a);
    }
       
    static  int  bigNumber (int[] array)
    {
        int min = array[0];

        for (int i=1; i<array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        } return min;
    }
}
