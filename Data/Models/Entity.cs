﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Entity
    {
        [Key]
        public long Id { get; set; }
        public int Status { get; set; }
    }
}
