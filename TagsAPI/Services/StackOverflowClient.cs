using Newtonsoft.Json;
using StackOverflowTagsAPI.Models;
using System.Text.Json;
using TagsAPI.Models;

namespace TagsAPI.Services
{
    public class StackOverflowClient
    {
        private readonly HttpClient _httpClient;
        public StackOverflowClient() 
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.stackexchange.com/2.3/")
            };
        
        }
        public async Task<IEnumerable<Tag>> GetTags()
        {
            const string url = "tags?order=desc&sort=popular&site=stackoverflow";

            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode) return [];

            var json = await response.Content.ReadAsStringAsync();

            var rootObject = JsonConvert.DeserializeObject<TagRootObject>(json);

            return rootObject?.Items ?? new List<Tag>();

            
        }

    }
}
