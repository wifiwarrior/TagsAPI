using TagsAPI.Interfaces;

namespace StackOverflowTagsAPI.DTOs
{
    //placeholder
    public record TagDTO(bool HasSynonyms, bool IsModeratorOnly, bool IsRequired, double Count, string Name) : ITagDTO
    {
    }
}
