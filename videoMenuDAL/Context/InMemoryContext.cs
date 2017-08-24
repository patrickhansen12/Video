using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using videoMenuEntity;

namespace videoMenuDAL.Context
{
    class InMemoryContext : DbContext
    {
        static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>()
                .UseInMemoryDatabase("TheDataBase").Options;

        public InMemoryContext() : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
    }
}
