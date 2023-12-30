﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEntity() 
        { 
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}
