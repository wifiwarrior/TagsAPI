using StackOverflowTagsAPI.Models;
using System.Text.Json.Serialization;

namespace TagsAPI.Models
{
    public class TagRootObject
    {
        [JsonPropertyName("items")]
        public List<Tag> Items { get; set; }
    }
}
