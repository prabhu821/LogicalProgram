namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Fibonacci Series \n2.Perfect Number " +
                    "\n3.Prime Number \n4.Reverse Number \n5.Stop Watch \n6.Coupon Number \n7.Day Of Week " +
                    "\n8.Temperature Conversion \n9.Exit");
                Console.WriteLine("\nEnter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Print(5);
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Check(10);
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckPrime(7);
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse(25);
                        break;
                    case 5:
                        StopWatch stopWatch=new StopWatch();
                        stopWatch.Start();
                        break;
                    case 6:
                        CouponNumber.GenerateCoupons(10);
                        break;
                    case 7:
                        DayOfWeek.DayofWeek();
                        break;
                    case 8:
                        TemperatureConversion temperatureConversion = new TemperatureConversion();
                        temperatureConversion.Conversion();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}