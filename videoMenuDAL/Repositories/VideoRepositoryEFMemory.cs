using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using videoMenuDAL.Context;
using videoMenuEntity;

namespace videoMenuDAL.Repositories
{
    public class VideoRepositoryEFMemory : IVideoRepository
    {
         InMemoryContext _context;

        public VideoRepositoryEFMemory(InMemoryContext context)
        {
            _context = context;
        }
        public Videoes Create(Videoes vid)
        {
           
            _context.Videoeses.Add(vid);
            _context.SaveChanges();
            return vid;
        }

        public List<Videoes> GetAll()
        {
            return _context.Videoeses.ToList();
        }

        public Videoes Get(int id)
        {
            return _context.Videoeses.FirstOrDefault(x => x.VideoId == id);
        }

        public Videoes Delete(int id)
        {
            var vid = Get(id);
            _context.Videoeses.Remove(vid);
          
            return vid;
        }
    }

    
}
