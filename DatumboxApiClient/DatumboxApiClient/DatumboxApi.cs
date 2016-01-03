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
    }
}