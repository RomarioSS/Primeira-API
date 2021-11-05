﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAPI.Models
{
    public class Context:DbContext
    {
      public  DbSet<Pessoa> pessoas { get; set; }
        public Context(DbContextOptions<Context>options):base(options)
        {
                
        }
    }
}
