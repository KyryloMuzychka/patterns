using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class Store
    {
        private Telecast news;
        private Telecast movie;
        private Telecast sports;
        private Telecast documentary;
        private Telecast comedyShow;

        private TVChannel channel_news;
        private TVChannel channel_entertainment;
        private TVChannel channel_documentary;
        private TVChannel channel_movie;
        private TVChannel channel_sports;      

        public static IIterator<TVChannel> channelIterator;
        public static IIterator<Telecast> telecastIterator;

        private Store()
        {            
            news = Telecast.CreateTelecast("Morning News");
            movie = Telecast.CreateTelecast("Blockbuster Movie");
            sports = Telecast.CreateTelecast("Sports Highlights");
            documentary = Telecast.CreateTelecast("Nature Documentary");
            comedyShow = Telecast.CreateTelecast("Comedy Night");
         
            channel_news = TVChannel.CreateTVChannel("News Network", new List<Telecast> { news, movie, sports });
            channel_entertainment = TVChannel.CreateTVChannel("Entertainment Channel", new List<Telecast> { movie, sports, comedyShow });
            channel_documentary = TVChannel.CreateTVChannel("Documentary Channel", new List<Telecast> { documentary, news, sports });
            channel_movie = TVChannel.CreateTVChannel("Movie Mania", new List<Telecast> { movie, documentary, comedyShow });
            channel_sports = TVChannel.CreateTVChannel("Sports Central", new List<Telecast> { sports, news, documentary });

            channelIterator = IteratorFactory.CreateIterator(new List<TVChannel> { channel_news, channel_entertainment, channel_documentary, channel_movie, channel_sports });
            telecastIterator = IteratorFactory.CreateIterator(channel_news.Telecasts);
        }

        public static void ChangeIterator(TVChannel channel)
        {
            telecastIterator = IteratorFactory.CreateIterator(channel.Telecasts);
        }      

        public static Store CreateStore()
        {
            return new Store();
        }
    }
}
