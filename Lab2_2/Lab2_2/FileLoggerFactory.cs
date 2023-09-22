using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class FileLoggerFactory : ILoggerFactory
    {
        private string filePath;

        public FileLoggerFactory(string filePath) 
        {
            this.filePath = filePath;
        }

        public ILogger createLogger()
        {
            return new FileLogger(filePath);
        }
    }
}
