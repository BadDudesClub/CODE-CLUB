using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace TwitterGitter.Main.Tests
{
    public class TweetStoreMemoryTests
    {
        [Fact(DisplayName = "Store and retrieve a tweet")]
        public void StoreAndGetTweet()
        {
            TweetStoreMemory tweetStore = new TweetStoreMemory();
            Tweet tweet = new Tweet()
            {
                TweetId = 1
            };

            tweetStore.InsertTweet(tweet);
            var tweetResult = tweetStore.GetTweet(tweet.TweetId);

            Assert.NotNull(tweetResult);
            Assert.Equal(tweet.TweetId, tweetResult.TweetId);
        }

        [Fact(DisplayName = "Test that is supposed to throw an exception")]
        public void ThrowExample()
        {
            TweetStoreMemory memory = null;
            Assert.Throws<NullReferenceException>(() => memory.GetTweet(5));
        }

        // test inserting an incomplete tweet
        // test inserting the same tweet twice
        // test the rest of the tweet fields (message)
        // test getting a nonexistent tweet
        // test various queries

    }
}