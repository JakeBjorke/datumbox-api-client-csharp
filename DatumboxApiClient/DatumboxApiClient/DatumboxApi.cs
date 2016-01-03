using System;
using System.Threading.Tasks;

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

        public async Task<string> SentimentAnalysisAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string TwitterSentimentAnalysis(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> TwitterSentimentAnalysisAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string SubjectivityAnalysis(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SubjectivityAnalysisAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string TopicClassification(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> TopicClassificationAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string SpamDetection(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SpamDetectionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string AdultContentDetection(string text)
        {
            throw new NotImplementedException();
        }


        public async Task<string> AdultContentDetectionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string ReadabilityAssessment(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> ReadabilityAssessmentAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string LanguageDetection(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> LanguageDetectionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string EducationalDetection(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EducationalDetectionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string GenderDetection(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GenderDetectionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string TextExtraction(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> TextExtractionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string KeywordExtraction(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> KeywordExtractionAsync(string text)
        {
            throw new NotImplementedException();
        }

        public string DocumentSimilarity(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<string> DocumentSimilarityAsync(string text)
        {
            throw new NotImplementedException();
        }
    }
}