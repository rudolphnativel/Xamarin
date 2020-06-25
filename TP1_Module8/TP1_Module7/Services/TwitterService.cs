using System;
using System.Collections.Generic;
using System.Text;
using TP1_Module7.BO;

namespace TP1_Module7.Services
{
    class TwitterService : ITwitterService__
    {
        User user = new User("Rudolp","password");
        public bool authenticate(User userTest)
        {
            if (userTest.login.Equals(user.login) && userTest.password.Equals(user.password))
            {
                return true;
            }
            else return false;
        }

        public List<Tweet> getTweets(string text)
        {
            if (text.Equals(user.login))
            {
                return user.tweets;
            }
            else return null;
        }
    }
}
