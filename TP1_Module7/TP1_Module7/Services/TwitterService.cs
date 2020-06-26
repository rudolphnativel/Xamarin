using System;
using System.Collections.Generic;
using System.Text;
using TP1_Module7.BO;

namespace TP1_Module7.Services
{
    class TwitterService : ITwitterService__
    {
        User user = new User("Rudolp", "password", new List<Tweet> {
                    new Tweet() {tweet = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", dataDate = DateTime.Now },
                    new Tweet() {tweet = "Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", dataDate = DateTime.Now },
                    new Tweet() {tweet = "maximus arcu lectus at lectus", dataDate = DateTime.Now },
                    new Tweet() {tweet = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce ipsum nisl, accumsan ac diam sed, scelerisque tempus sapien.", dataDate = DateTime.Now },
                    new Tweet() {tweet = "Praesent eu", dataDate = DateTime.Now }
                });
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
