using System;
using System.Collections.Generic;
using System.Text;
using videoMenuEntity;

namespace videoMenuBLL
{
    public interface IVideoService
    {
        Videoes Create(Videoes vid);
        List<Videoes> GetAll();
        Videoes Get(int id);

        Videoes Update(Videoes vid);
        Videoes Delete(int id);

    }
}
