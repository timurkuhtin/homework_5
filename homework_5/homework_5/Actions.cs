using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Actions
    {
        public Result First()
        {
            Logger logger = new Logger();
            Result results = new Result();

            logger._logTime = DateTime.Now;
            logger._logType = "Info";
            logger._message = "Start method: First\n";

            File.AppendAllText("log.txt", $"{logger._logTime} {logger._logType} {logger._message}");

            results.status = true;
            return results;
        }

        public Result Second()
        {
            Logger logger = new Logger();
            Result results = new Result();

            logger._logTime = DateTime.Now;
            logger._logType = "Warning";
            logger._message = "Skipped logic in method: Second\n";

            File.AppendAllText("log.txt", $"{logger._logTime} {logger._logType} {logger._message}");

            results.status = true;
            return results;
        }

        public Result Third()
        {
            Logger logger = new Logger();
            Result results = new Result();

            logger._logTime = DateTime.Now;
            results.status = false;
            results.message = "I broke a logic";
            return results;
        }
    }
}
