using System;
using System.Threading;

namespace Tiktok
{
    public class Clock
    {
        private DateTime innerTime;
        private DateTime alarmTime;
        private ThreadStart timerRef;
        private Thread timer;

        private void Time()
        {
            bool isAlarming = false;
            while (true)
            {
                this.innerTime = DateTime.Now;
                if (isAlarming == true)
                {
                    this.alarm();
                    if ((this.innerTime - this.alarmTime).Seconds >= 10) //响铃十秒
                    {
                        isAlarming = false;
                    }
                }
                else
                {
                    this.nalarm();
                }
                if ((this.innerTime - this.alarmTime).Seconds == 0)
                {
                    isAlarming = true;
                }
            }
        }

        private void printAlarm()
        {
            Console.WriteLine("Alarming!");
        }
        
        private void printnAlarm()
        {
            Console.WriteLine("Not Alarming!");
        }

        public Clock()
        {
            innerTime = DateTime.Now;
            alarmTime = DateTime.Now.AddSeconds(3);//三秒后响铃
            timerRef = new ThreadStart(Time);
            timer = new Thread(timerRef);
            alarm += new AlarmHandler(printAlarm);
            nalarm += new AlarmHandler(printnAlarm);
        }

        public void startTiming()
        {
            timer.Start();
        }

        public void stopTiming()
        {
            timer.Abort();
        }
        
        public event AlarmHandler alarm;
        public event AlarmHandler nalarm;

        public delegate void AlarmHandler();
    }
}