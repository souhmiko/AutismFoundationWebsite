﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ShareProject.Models
{
    public partial class AgeRange
    {
        public long Id { get; set; }
        public long AgeRange1 { get; set; }

        public virtual ResourceAgeRange AgeRange1Navigation { get; set; }
    }
}