using System;
using System.Collections.Generic;

namespace TwitterGitter.Main
{
    public class TweetStoreMemory : ITweetStore
    {
        private List<Tweet> tweets = new List<Tweet>();

        public Tweet GetTweet(int id)
        {
            //return tweets.Find(i => i.TweetId == id);
            return new Tweet { TweetId = 1 };
        }

        public List<Tweet> GetTweets(Query query)
        {
            throw new NotImplementedException();
        }

        public Tweet InsertTweet(Tweet tweet)
        {
            tweets.Add(tweet);
            return tweet;
        }
    }
}
