using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using videoMenuBLL.Services;
using videoMenuDAL;

namespace videoMenuBLL
{
    //public IVideoService GetVideoService();
    public class BLLFacade
    {


        get{ return new VideoService(new DALFacade().VideoRepository);}
}


}
}
