using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.IBLL
{
    public  interface IBaseService<T>
    {
        List<T> BaseSelectAll();

        int BaseInsert(T Obj);

        int BaseUpdate(T Obj);

        int BaseDelete(T Obj);
    }
}
