using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IBLL
{
    public interface ICaseManageService<T>
    {
        List<T> SelectTop2();
    }
}
