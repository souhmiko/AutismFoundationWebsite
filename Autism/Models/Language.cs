﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Autism.Models
{
    public partial class Language
    {
        public Language()
        {
            ResourceAttachment = new HashSet<ResourceAttachment>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ResourceAttachment> ResourceAttachment { get; set; }
    }
}