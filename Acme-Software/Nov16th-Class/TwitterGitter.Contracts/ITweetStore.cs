using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterGitter.Contracts
{
    public interface ITweetStore
    {
        Tweet GetTweet(int id);
        List<Tweet> GetTweets(Query query);
        Tweet InsertTweet(Tweet tweet);
    }

    public class Tweet
    {
        public int TweetId { get; set; }
    }

    public class Query
    {
        public HashSet<string> HashTags { get; set; }
        public HashSet<string> Users { get; set; }
        public HashSet<string> SearchTerms { get; set; }

        public Query()
        {
            HashTags = new HashSet<string>();
            Users = new HashSet<string>();
            SearchTerms = new HashSet<string>();
        }
    }
}
