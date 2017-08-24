using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using videoMenuEntity;

namespace videoMenuDAL.Context
{
   public class InMemoryContext : DbContext
    {
        private static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("The db").Options;
        public InMemoryContext() : base(options)
        {
            
        }
public DbSet<Videoes>Videoeses { get; set; }
    }
}
