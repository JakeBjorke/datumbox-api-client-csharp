using System;

namespace DatumboxApiClient
{
    public class DatumboxApi
    {
        private readonly string _apiKey;

        public DatumboxApi(string apiKey)
        {
            _apiKey = apiKey;
        }

        public string SentimentAnalysis(string text)
        {
            throw new NotImplementedException();
        }

        public string TwitterSentimentAnalysis(string text)
        {
            throw new NotImplementedException();
        }

        public string SubjectivityAnalysis(string text)
        {
            throw new NotImplementedException();
        }

        public string TopicClassification(string text)
        {
            throw new NotImplementedException();
        }

        public string SpamDetection(string text)
        {
            throw new NotImplementedException();
        }

        public string AdultContentDetection(string text)
        {
            throw new NotImplementedException();
        }

        public string ReadabilityAssessment(string text)
        {
            throw new NotImplementedException();
        }

        public string LanguageDetection(string text)
        {
            throw new NotImplementedException();
        }

        public string EducationalDetection(string text)
        {
            throw new NotImplementedException();
        }

        public string GenderDetection(string text)
        {
            throw new NotImplementedException();
        }

        public string TextExtraction(string text)
        {
            throw new NotImplementedException();
        }

        public string KeywordExtraction(string text)
        {
            throw new NotImplementedException();
        }

        public string DocumentSimilarity(string text)
        {
            throw new NotImplementedException();
        }
    }
}