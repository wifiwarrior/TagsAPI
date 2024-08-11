using System.Text.Json.Serialization;

namespace TagsAPI.Models
{
    public abstract class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
