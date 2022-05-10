using System;
using System.IO;

namespace Homework_5
{
    internal class Starter
    {
        public int Run()
        {
            Actions action = new Actions();
            Result result = new Result();
            Logger logger = new Logger();

            for (int i = 0; i < 100; i++)
            {
                int r = new Random().Next(1, 4);
                switch (r)
                {
                    case 1:
                        result = action.First();                        
                        break;
                    case 2:
                        result = action.Second();
                        break;
                    case 3:
                        result = action.Third();
                        break;
                }

                if (!result.status)
                {
                    logger._logTime = DateTime.Now;
                    logger._logType = "Error";
                    logger._message = "Action failed by a reason: " + result.message + "\n";
                    File.AppendAllText("log.txt", $"{logger._logTime} {logger._logType} {logger._message}");
                }
            }

            return 0;
        }
    }
}
