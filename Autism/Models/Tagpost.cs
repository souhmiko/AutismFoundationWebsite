﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Autism.Models
{
    public partial class Tagpost
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public long TagId { get; set; }

        public virtual BlogPost Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}