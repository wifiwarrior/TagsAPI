using System.Text.Json.Serialization;
using TagsAPI.Models;
using Newtonsoft.Json;

namespace StackOverflowTagsAPI.Models
{
    public class Tag : BaseEntity
    {

        //Autoinclude

        //public List<Collective>? Collectives { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("has_synonyms")]

        public bool HasSynonyms { get; set; }

        [JsonProperty("is_moderator_only")]

        public bool IsModeratorOnly { get; set; }

        [JsonProperty("is_required")]
        public bool IsRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        }
    }

