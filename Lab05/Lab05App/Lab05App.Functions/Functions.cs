namespace Lab05App.Functions
{
    public class Functions
    {
        public static bool ThreadTest()
        {
            var threadDelegate = new ThreadStart(SortArr);
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(threadDelegate) { IsBackground = true };
                thread.Start();
            }

            return true;
        }

        public static void InfiniteThreadStart()
        {
            var threadDelegate = new ThreadStart(SortArr);
            while (true)
            {
                Thread newThread = new Thread(threadDelegate) { IsBackground = true };
                newThread.Start();
            }
        }

        private static int[] CreateArr()
        {
            var array = new int[1000];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);
            }
            return array;
        }

        private static void SortArr()
        {
            var arr = CreateArr();
            Array.Sort(arr);
        }
    }
}