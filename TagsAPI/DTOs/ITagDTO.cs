﻿namespace StackOverflowTagsAPI.DTOs
{
    public interface ITagDTO
    {
        double Count { get; }
        bool HasSynonyms { get; }
        bool IsModeratorOnly { get; }
        bool IsRequired { get; }
        string Name { get; }
    }
}
