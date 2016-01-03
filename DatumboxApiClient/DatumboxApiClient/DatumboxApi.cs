using System.ComponentModel;

namespace DatumboxApiClient
{
    public class DatumboxApi
    {
        private const string API_BASE_URL = "http://api.datumbox.com/1.0/";

        private const string SENTIMENT_ANALYSIS_PATH = "SentimentAnalysis.json";

        private const string TWITTER_SENTIMENT_ANALYSIS_PATH = "TwitterSentimentAnalysis.json";

        private const string TOPIC_CLASSIFICATION_PATH = "TopicClassification.json";

        private const string SPAM_DETECTION_PATH = "SpamDetection.json";

        private const string ADULT_CONTENT_DETECTION_PATH = "AdultContentDetection.json";

        private const string READABILITY_ASSESSMENT_PATH = "ReadabilityAssessment.json";

        private const string LANGUAGE_DETECTION_PATH = "LanguageDetection.json";

        private const string COMERCIAL_DETECTION_PATH = "CommercialDetection.json";

        private const string EDUCATIONAL_DETECTION_PATH = "EducationalDetection.json";

        private const string GENDER_DETECTION_PATH = "GenderDetection.json";

        private const string TEXT_EXTRACTION_PATH = "TextExtraction.json";

        private const string KEYWORD_EXTRACTION_PATH = "KeywordExtraction.json";

        private const string DOCUMENT_SIMILARITY_PATH = "DocumentSimilarity.json";

        private readonly string _apiKey;

        public DatumboxApi(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}