using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryMS.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? BookImage { get; set; }
    }
}
