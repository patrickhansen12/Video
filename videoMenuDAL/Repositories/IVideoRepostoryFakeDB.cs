using System;
using System.Collections.Generic;
using System.Text;
using videoMenuEntity;
using System.Linq;

namespace videoMenuDAL.Repositories
{
    class VideoRepositoryFakeDB : IVideoRepository
    {
        private static List<Video> videos = new List<Video>();
        private static int Id = 1;

        public Video Create(Video video)
        {
            Video newVideo;
            videos.Add(newVideo = new Video()
            {
                Name = video.Name,
                Id = Id++
            });
            return newVideo;
        }

        public Video Delete(int Id)
        {
            var vid = Get(Id);
            videos.Remove(vid);
            return vid;
        }

        public Video Get(int Id)
        {
            return videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return new List<Video>(videos);
        }
    }
}
