﻿using System;
using System.Collections.Generic;

namespace zh3.Models;

public partial class Time
{
    public byte TimeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lesson { get; } = new List<Lesson>();
}
