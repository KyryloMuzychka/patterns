using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class StdoutLoggerFactory : ILoggerFactory
    {
        public ILogger createLogger()
        {
            return new StdoutLogger();
        }
    }
}
