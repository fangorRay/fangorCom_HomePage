using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IBLL
{
    public  interface INewsManageService<T>
    {
        List<T> SelectNewsTop9();
    }
}
