using System;

public interface ITweetStore
{
    //Create returns the ID of the stored tweet
    int Create();
    //Read returns the requested Tweet
    Tweet Read();
    //Update returns the updated Tweet Object
    Tweet Update();
    //Delete returns the ID of the deleted Tweet
    int Delete();
}

public interface ITweet
{
    int ID { get; set; }
    string Message { get; set; }
    string Tweeter { get; set; }
}

public class Tweet : ITweet
{
    private int _id;
    private string _message;
    private int _tweeter;

    private Tweet(){

    }
    private Tweet(int id, string message, int tweeter)
    {
            _id = id;
            _message = message;
            _tweeter = tweeter;
    }

    public int ID
    {
        get { return _id;}
        set { _id = value;}
    }
    
    public string Message
    {
        get { return _message;}
        set { _message = value;}
    }
    
    public int Tweeter
    {
        get { return _tweeter;}
        set { _tweeter = value;}
    }

    public class TweetFactory()
    {
        public static Tweet CreateTweet(int id, string message, int tweeter)
        {
            if (id > 0 && !string.IsNullOrWhiteSpace(message) && tweeter > 0)
            {
                return new Tweet(id, message, tweeter);    
            }
            else
            {
                retun null;
            }
        }
    }
}