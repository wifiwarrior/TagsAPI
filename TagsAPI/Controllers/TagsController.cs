using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using StackOverflowTagsAPI.Models;
using TagsAPI.Interfaces;
using TagsAPI.Services;

namespace TagsAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TagsController : ControllerBase
{
    private readonly ITagsDbRepository _tagsRepo;
    private readonly StackOverflowClient _client;

    public TagsController(ITagsDbRepository tagsDbRepo, StackOverflowClient client)
    {
        _tagsRepo = tagsDbRepo;
        _client = client;
    }

    [HttpGet]
    public async Task<IActionResult> GetTags() => await _client.GetTags() switch
    {
        List<Tag> tags => Ok(tags),
        null => NotFound()
    };
}
