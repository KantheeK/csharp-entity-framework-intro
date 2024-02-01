﻿using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO AuthorDTO { get; set; }
        public PublisherDTO PublisherDTO { get; set; }
    }
}
