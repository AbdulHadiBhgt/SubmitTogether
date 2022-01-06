using System;
using System.Threading;

namespace SubmitTogether
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ids = new string[] { "1", "2", "3" };

            for (int i = 0; i < ids.Length; i++)
            {
                thread t = new thread(ids[i]);
            }
        }
    }

    public class thread
    {
        public static int count = 0;
        public string id;
        public thread(string id)
        {
            this.id = id;
            Thread t = new Thread(new ThreadStart(() =>
            {
                try
                {
                    if (this.id == "1")
                    {
                        Thread.Sleep(500);
                        int i = 1;
                        int j = 0;
                        int k = i / j;
                    }
                    else if (this.id == "2")
                    {
                        Thread.Sleep(5000);
                    }
                    else if (this.id == "3")
                    {
                        Thread.Sleep(1000);
                    }

                    count++;

                    while (count < 3)
                    {
                        Console.WriteLine("Waiting : {0}", this.id);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    count++;
                }
                finally
                {
                    Console.WriteLine("Finished : {0}", this.id);
                }



            }));
            t.Start();
        }
    }

}
