using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IDAL
{
    public  interface IBaseDAO<T>
    {
        List<T> BaseSelectAll();

        int BaseInsert(T Obj);

        int BaseUpdate(T Obj);

        int BaseDelect(T Obj);
    }
}
