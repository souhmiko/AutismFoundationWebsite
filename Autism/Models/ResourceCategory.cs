﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Autism.Models
{
    public partial class ResourceCategory
    {
        public ResourceCategory()
        {
            Resource = new HashSet<Resource>();
            ResourceTag = new HashSet<ResourceTag>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Resource> Resource { get; set; }
        public virtual ICollection<ResourceTag> ResourceTag { get; set; }
    }
}