using System;
using System.Collections.Generic;
using System.Text;
using videoMenuDAL;
using videoMenuDAL.Context;
using videoMenuDAL.Repositories;

namespace videoMenuDAL.OUW 
{
    public class UnitOfWorkMem : IUnitOfWork
    {
        public IVideoRepository VideoRepository { get; internal set; }
        private InMemoryContext context;    
        public UnitOfWorkMem()

        {
            context = new InMemoryContext();
            VideoRepository = new VideoRepositoryEFMemory(context);
        }

        
        public int complete()
        {
           return context.SaveChanges();
        }

        public void Dispose()
        {
context.Dispose();
        }
    }

}
