using System;
using System.Collections.Generic;
using System.Text;

using videoMenuDAL.Repositories;

namespace videoMenuDAL
{
    public class DALFacade
    {
        public IVideoRepository VideoRepository => new VideoRepostoryFakeDB();

    }
}
