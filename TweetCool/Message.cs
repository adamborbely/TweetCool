using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetCool
{
    public class Message
    {
        public string Username { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string username, string text)
        {
            Username = username;
            Text = text;
            TimeStamp = DateTime.Now;
        }
    }
}
