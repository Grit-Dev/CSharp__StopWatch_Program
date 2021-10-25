using System;

namespace ConsoleApp3
{
    public class StopWatch
    {
       private DateTime StartTime;
       private DateTime FinishTime;
      

       

        public void Start()
        {
            StartTime = DateTime.Now;
            
        }

        public void Stop()
        {
           
            FinishTime = DateTime.Now;
            
        }

        public TimeSpan GetInterval()
        {
            return FinishTime - StartTime;
      
        }
    }
}


