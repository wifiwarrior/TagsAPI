using Microsoft.EntityFrameworkCore;
using StackOverflowTagsAPI.Models;

namespace StackOverflowTagsAPI.Database
{
    public class TagsDbContext(DbContextOptions<TagsDbContext>options) : DbContext(options)
    {
        DbSet<Tag> Tags { get; set; }
        //DbSet<Collective> Collectives { get; set; }
        //DbSet<CollectiveExternalLink> ExternalLinks { get; set; }


    }
}
