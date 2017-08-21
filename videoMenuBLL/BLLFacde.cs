using System;
using System.Collections.Generic;
using System.Text;
using videoMenuBLL.Services;

namespace videoMenuBLL
{
   public class BLLFacade
    {
        public IVideoService GetVideoService()
        {
            return new VideoService();
        }
    }
}
