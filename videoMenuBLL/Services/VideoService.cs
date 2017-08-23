using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using videoMenuDAL;
using videoMenuEntity;

namespace videoMenuBLL.Services
{
    class VideoService : IVideoService
    {
        public IVideoRepository repo;

        public VideoService(IVideoRepository repo)
        {
            this.repo = repo;
        }
      


        public Videoes Delete(int Id)
        {
            return repo.Delete(Id);

        }   


        public Videoes Get(int Id)
        {
            return repo.Get(Id);
            
        }

        public Videoes Create(Videoes vid)
        {
            return repo.Create(vid);
        }

        public List<Videoes> GetAll()
        {
            return repo.GetAll();
        }

        public Videoes Update(Videoes vid)
        {
            return null;
        }
    }
}
