using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1
{
    public partial class TVForm : Form
    {
        public TVForm()
        {
            InitializeComponent();
            Store.CreateStore();
            ChannelNameLabel.Text = Store.channelIterator.Current().Name;
            TelecastNameLabel.Text = Store.telecastIterator.Current().Name;
        }

        private void PrevChannelButton_Click(object sender, EventArgs e)
        {
            ChannelNameLabel.Text = Store.channelIterator.Prev().Name;            
            IteratorFactory.CreateIterator(Store.channelIterator.Current().Telecasts);
            Store.ChangeIterator(Store.channelIterator.Current());
            TelecastNameLabel.Text = Store.telecastIterator.Current().Name;
            ChannelNumeric.Value = Store.channelIterator.GetPosition();
            TelecastNumeric.Value = Store.telecastIterator.GetPosition();
        }

        private void NextChannelButton_Click(object sender, EventArgs e)
        {
            ChannelNameLabel.Text = Store.channelIterator.Next().Name;
            IteratorFactory.CreateIterator(Store.channelIterator.Current().Telecasts);
            Store.ChangeIterator(Store.channelIterator.Current());
            TelecastNameLabel.Text = Store.telecastIterator.Current().Name;
            ChannelNumeric.Value = Store.channelIterator.GetPosition();
            TelecastNumeric.Value = Store.telecastIterator.GetPosition();
        }
        
        private void PrevTelecastButton_Click(object sender, EventArgs e)
        {
            TelecastNameLabel.Text = Store.telecastIterator.Prev().Name;           
            TelecastNumeric.Value = Store.telecastIterator.GetPosition();
        }

        private void NextTelecastButton_Click(object sender, EventArgs e)
        {
            TelecastNameLabel.Text = Store.telecastIterator.Next().Name;
            TelecastNumeric.Value = Store.telecastIterator.GetPosition();
        }

        private void MoveToChannel_Click(object sender, EventArgs e)
        {            
            Store.channelIterator.SetCurrent(Int32.Parse(ChannelNumeric.Value.ToString()));
            ChannelNameLabel.Text = Store.channelIterator.Current().Name;
            IteratorFactory.CreateIterator(Store.channelIterator.Current().Telecasts);
            Store.ChangeIterator(Store.channelIterator.Current());
            TelecastNameLabel.Text = Store.telecastIterator.Current().Name;
            TelecastNumeric.Value = Store.telecastIterator.GetPosition();
        }
    }
}
