﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
