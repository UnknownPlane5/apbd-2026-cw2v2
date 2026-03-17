namespace Tutorial2;
class Program
{
    static void Main(string[] args)
    {
        //I like cheese
        Console.WriteLine("Feature2!");
        int a = 20;
        int b = 10;
        int d = 0;
        StatisticsHelper(a, b, d);
        
    }
    static void StatisticsHelper(int a, int b, int c)
    { 
       c=a*b;
       Console.WriteLine(c);
    }
    static int CalculateAverage(int[] values)
    {
        int avg = 0;
        int a = 0;
        foreach (int i in values)
        {
            a +=values[i];
        }
        avg = a / values.Length;
        return avg;
    }
    
}

