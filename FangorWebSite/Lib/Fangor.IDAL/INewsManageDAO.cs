using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IDAL
{
    public interface INewsManageDAO<T>
    {
        List<T> SelectNewsTop9();
    }
}
