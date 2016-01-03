namespace DatumboxApiClient
{
    public class DatumboxApi
    {
        private const string SENTIMENT_ANALYSIS_URL = "http://api.datumbox.com/1.0/SentimentAnalysis.json";

        private const string TWITTER_SENTIMENT_ANALYSIS_URL = "http://api.datumbox.com/1.0/TwitterSentimentAnalysis.json";



        private readonly string _apiKey;

        public DatumboxApi(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}