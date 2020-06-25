using System;
using System.Collections.Generic;
using System.Text;
using TP1_Module7.BO;

namespace TP1_Module7.Services
{
    interface ITwitterService__
    {
        Boolean authenticate(User user);
        List<Tweet> getTweets(String text);
    }
}
