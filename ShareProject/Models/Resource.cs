﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ShareProject.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceAttachment = new HashSet<ResourceAttachment>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long ResCategoryId { get; set; }

        public virtual ResourceCategory ResCategory { get; set; }
        public virtual ICollection<ResourceAttachment> ResourceAttachment { get; set; }
    }
}