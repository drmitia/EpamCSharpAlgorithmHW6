namespace EpamHW6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int am = Convert.ToInt32(Console.ReadLine());
            int bm = Convert.ToInt32(Console.ReadLine());
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gcdMain(am, bm, cm)); 
            
            static int gcdMain(int a, int b, int c)
            {
                static int gcd(int a, int b)
                {
                    while (a != b)
                    {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else
                        {
                            b = b - a;
                        }
                    }
                    return a;
                }
                return gcd(gcd(a, b), c);
            }


        }
        
        
    }
}