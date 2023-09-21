using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class StdoutLoggerFactory : LoggerFactory
    {
        public Logger createLogger()
        {
            return new StdoutLogger();
        }
    }
}
