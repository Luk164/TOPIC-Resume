﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MainLib.Entities
{
    public class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
