using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.WriteLine("After file download is called");
        }
        static void Download()
        {
            Network.Download(() => Console.WriteLine("Download complete"));           
        }
        //imaginary external network library
        class Network
        {
            static public void Download(Action callback)
            {
                Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    callback();
                });
            }
        }
    }
}
