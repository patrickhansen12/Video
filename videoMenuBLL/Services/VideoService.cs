using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using videoMenuDAL;
using videoMenuEntity;

namespace videoMenuBLL.Services
{
    class VideoService : IVideoService
    {
        public Videoes Create(Videoes vid)
        {
            Videoes newVid;
            FakeDB.Videoes.Add(newVid = new Videoes()
            {
                VideoName = vid.VideoName,
                VideoId = FakeDB.Id++
            });
            return newVid;
        }


        public Videoes Delete(int Id)
        {
            var vid = Get(Id);
            FakeDB.Videoes.Remove(vid);

            return vid;
           
        }   


        public Videoes Get(int Id)
        {
            return FakeDB.Videoes.FirstOrDefault(x => x.VideoId == Id); 
        }

        public List<Videoes> GetAll()
        {
           return new List<Videoes>(FakeDB.Videoes);
        }

        public Videoes Update(Videoes vid)
        {
            var vidFromDb = Get(vid.VideoId);
            if (vidFromDb == null)
            {
                throw new InvalidOperationException("Video not found");
            }
            vidFromDb.VideoName = vid.VideoName;
            return vidFromDb;
        }
    }
}
