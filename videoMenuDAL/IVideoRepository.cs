using System;
using System.Collections.Generic;
using System.Text;
using videoMenuEntity;

namespace videoMenuDAL
{
   public interface IVideoRepository
    {
        Videoes Create(Videoes vid);
        List<Videoes> GetAll();
        Videoes Get(int id);
        
        Videoes Delete(int id);
    }
}
