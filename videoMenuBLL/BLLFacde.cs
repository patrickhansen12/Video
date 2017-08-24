using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using videoMenuBLL.Services;
using videoMenuDAL;

namespace videoMenuBLL
{

    public class BLLFacade
    {
        public IVideoService VideoService
        {
            get { return new VideoService(new DALFacade().VideoRepository); }
        }
    }
}

