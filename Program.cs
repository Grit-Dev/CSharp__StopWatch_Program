

using System;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {

            var stopWatch = new StopWatch();
            bool isTrue = true;
            string userInput;
            bool isStartedTime = false;
            bool isStopped = false;


            do
            {
                
                Console.WriteLine($"Enter Start to 'start' the stop watch");
                Console.WriteLine($"Enter Stop to 'stop' the stop watch");
                Console.WriteLine($"Enter Exit to 'exit' the stop watch");
                userInput = Console.ReadLine();
                Console.WriteLine();



                if (userInput.ToLower() == "start")
                {

                    if (isStartedTime == false)
                    {
                        stopWatch.Start();
                        Console.WriteLine("The stop watch has started \n");
                        isStartedTime = true;
                    }
                    else
                    {
                        Console.WriteLine("The timer has already started!  \n");

                    }

                }

                else if (userInput.ToLower() == "stop")
                {

                    if (isStopped == false)
                    {
                        stopWatch.Stop();
                        Console.WriteLine($"The stop watch has stopped and the timer is: [{stopWatch.GetInterval()}] \n");

                        isStartedTime = false;

                        isStopped = true;
                    }
                    else
                    {
                        Console.WriteLine("The Stop Watch has already been stopped! \n");
                    }
                }   
                
                else if (userInput.ToLower() == "exit")
                {
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("ERROR: Please try again. You did not enter a valid input \n");

                }
                
            }
            while (isTrue);

            Console.WriteLine("Thanks for using the the stopwatch");

           

           
        }
    }
}


