﻿using LuckyMIlko.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyMIlko.Data
{
    public class AppDbContext: DbContext
    {

        public DbSet<Suerte> Suertes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
