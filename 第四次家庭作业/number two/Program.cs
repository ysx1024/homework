using System;
using System.Threading;

namespace number_two
{
    public delegate void AlarmTick(Object a, Alarm t);
    public delegate void AlarmGo(Object a, Alarm t);

    public class Alarm
    {
        public int S, M, H;

        public Alarm(int a,int b,int c)
        {
            S = a;
            M = b;
            H = c;
        }
        public event AlarmTick Tick;
        public event AlarmGo alar;

        public void Alarmtick()
        {
            while (true)
            {
                Thread.Sleep(100);
                S++;
                if (S == 61)
                {
                    M++;
                    S = 0;
                }
                if (M == 61)
                {
                    H++;
                    M = 0;
                }
                if (H == 25)
                {
                    H = 1;
                }
                Tick(null, this);
                alar(null, this);
            }    
        }
    }
    class Program
    {
        static void tick(object a,Alarm t)
        {
            Action<int> action = s => Console.WriteLine(s);
            action(t.S);
            action(t.M);
            action(t.H);
        }
        static void alarm(object a, Alarm t)
        {
            if (t.S == 12 && t.M == 19 && t.H == 16)
                Console.WriteLine("响铃");
        }
        static void Main(string[] args)
        {
            Alarm a = new Alarm(50,18,16);
            a.Tick += tick;
            a.alar += alarm;
            a.Alarmtick();

            Console.ReadLine();
        }
    }
}
