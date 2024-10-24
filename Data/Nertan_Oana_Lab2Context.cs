﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nertan_Oana_Lab2.Models;

namespace Nertan_Oana_Lab2.Data
{
    public class Nertan_Oana_Lab2Context : DbContext
    {
        public Nertan_Oana_Lab2Context (DbContextOptions<Nertan_Oana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nertan_Oana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Nertan_Oana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Nertan_Oana_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
