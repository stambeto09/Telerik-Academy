using System;
using System.Linq;
using System.Threading;

namespace ExtensionMethods
{
    public delegate void DelegateTimer();
    public class Timer
    {
        public static void ExecuteTime(int eachSec, int interval)
        {
            int currentSec=0;
            while (interval!=0)
            {
                if (currentSec%eachSec==0)
                {
                    Console.WriteLine("Executed!"); 
                }
                Thread.Sleep(1000);
                interval--;
                currentSec++;
            }
        }
    }
}
