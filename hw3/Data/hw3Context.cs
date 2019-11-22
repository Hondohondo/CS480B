using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hw3.Models;

namespace hw3.Data
{
    public class hw3Context : DbContext
    {
        public hw3Context (DbContextOptions<hw3Context> options)
            : base(options)
        {
        }

        public DbSet<hw3.Models.Quote> Quote { get; set; }

        public DbSet<hw3.Models.Author> Author { get; set; }
    }
}
