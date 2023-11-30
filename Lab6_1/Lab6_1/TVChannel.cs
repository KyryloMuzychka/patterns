using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class TVChannel
    {
        public string Name { get; set; }
        public List<Telecast> Telecasts { get; set; }

        public TVChannel(string name)
        {
            Name = name;
            Telecasts = new List<Telecast>();
        }

        public static TVChannel CreateTVChannel(string name, List<Telecast> telecasts)
        {
            var channel = new TVChannel(name);
            channel.Telecasts.AddRange(telecasts);
            return channel;
        }
    }
}
