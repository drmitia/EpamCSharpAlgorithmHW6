namespace EpamHW6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 12;
            int nearestPrime = FindNearestPrime(b);
            Console.WriteLine(nearestPrime);
            static bool IsPrime(int n)
            {
                if (n <= 1)
                {
                    return false;
                }

                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            static int FindNearestPrime(int num)
            {
                int smallerPrime = num - 1;
                int largerPrime = num + 1;

                while (true)
                {
                    if (IsPrime(largerPrime))
                    {
                        return largerPrime;
                    }
                    else if (IsPrime(smallerPrime))
                    {
                        return smallerPrime;
                    }                   
                    smallerPrime--;
                    largerPrime++;
                }
            }

        }
    }
}