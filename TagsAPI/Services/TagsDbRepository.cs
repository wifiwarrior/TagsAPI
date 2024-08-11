using StackOverflowTagsAPI.Database;
using StackOverflowTagsAPI.Models;
using TagsAPI.Interfaces;

namespace TagsAPI.Services
{
    public class TagsDbRepository(TagsDbContext context) : DbRepository<Tag>(context), ITagsDbRepository
    {
        //do update'owania bazy danych

        public override async Task<Tag> Update(Tag tag)
        {
            var dbTag = await Get(tag.Id);
            if (dbTag is not null)
            {
                dbTag.IsRequired = tag.IsRequired;
                dbTag.HasSynonyms = tag.HasSynonyms;
                dbTag.Count = tag.Count;
                dbTag.IsModeratorOnly = tag.IsModeratorOnly;
                dbTag.Name = tag.Name;
                await _context.SaveChangesAsync();
            }
            return dbTag; 
        }

    //    public override async Task<Tag>Add(Tag tag)
    //    {
    //        var dbTag
    //    }
    }
}
