namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Threading");
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer 1")); 
            Thread thread2 = new Thread(CountUp); 
            thread1.Start();
            thread2.Start();
            
            //CountDown();
            //CountUp();

            Console.WriteLine(mainThread.Name + " is complete");
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 " + i + " Second");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 Completed");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 " + i + " Second");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 Completed");
        }
    }
}