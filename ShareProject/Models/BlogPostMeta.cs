﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ShareProject.Models
{
    public partial class BlogPostMeta
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }

        public virtual BlogPost Post { get; set; }
    }
}