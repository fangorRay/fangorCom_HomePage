using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IDAL
{
    public interface ICaseManageDAO<T>
    {
        List<T> SelectTop2();
    }
}
