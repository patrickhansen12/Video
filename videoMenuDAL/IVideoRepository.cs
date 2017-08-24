using System;
using System.Collections.Generic;
using System.Text;
using videoMenuEntity;

namespace videoMenuDAL
{
    public interface IVideoRepository
    {
        Video Create(Video video);

        List<Video> GetAll();
        Video Get(int Id);

        Video Delete(int Id);
    }
}
