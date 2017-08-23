using System;
using System.Collections.Generic;
using System.Text;
using videoMenuEntity;
using System.Linq;

namespace videoMenuDAL.Repositories
{
    class VideoRepostoryFakeDB : IVideoRepository
    {

        #region
        private static int Id = 1;
        private static List<Videoes> Videoes = new List<Videoes>();
        #endregion
        public Videoes Create(Videoes vid)
        {
            Videoes newVid;
            Videoes.Add(newVid = new Videoes()
            {
                VideoName = vid.VideoName,
                VideoId = Id++
            });
            return newVid;
        }

        public List<Videoes> GetAll()
        {
            return new List<Videoes>(Videoes);
        }

        public Videoes Get(int id)
        {
            return Videoes.FirstOrDefault(x => x.VideoId == Id);
        }

        public Videoes Update(Videoes vid)
        {
            return null;
        }   

        public Videoes Delete(int id)
        {
            var vid = Get(Id);
            Videoes.Remove(vid);

            return vid;
        }
    }
}
