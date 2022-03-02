﻿using System;
using System.Collections.Generic;

namespace MovieDB
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? RunTime { get; set; }
    }
}
