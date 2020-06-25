using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Module7.BO
{
    class User
    {
        public User()
        {
        }

        public User(string login, string password, List<Tweet> tweets)
        {
            this.login = login;
            this.password = password;
            this.tweets = tweets;
        }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string login { get; set; }
        public string password { get; set; }
        public List<Tweet> tweets { get; set; }

    }
}
