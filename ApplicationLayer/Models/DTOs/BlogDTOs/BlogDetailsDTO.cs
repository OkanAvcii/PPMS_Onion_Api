﻿using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.BlogDTOs
{
    public class BlogDetailsDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? SourceUrl { get; set; }

        public AppUser AppUser { get; set; }


        public DateTime AddedDate { get; set; }
    }
}
