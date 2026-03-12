namespace Tutorial2;
class Program
{
    static void Main(string[] args)
    {
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
}

