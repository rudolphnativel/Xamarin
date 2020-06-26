using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Module7.BO
{
    class Tweet
    {

        public string tweet { get; set; }
        public DateTime dataDate { get; set; }

        public Tweet()
        {
        }

        public Tweet(string tweet, DateTime dataDate)
        {
            this.tweet = tweet;
            this.dataDate = dataDate;
        }
    }
}
