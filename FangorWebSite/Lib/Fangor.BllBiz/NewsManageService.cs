using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.BllBiz
{
    public class NewsManageService : Fangor.IBLL.INewsManageService<Fangor.Model.Articles>, Fangor.IBLL.IBaseService<Fangor.Model.Articles>
    {
        public List<Model.Articles> SelectNewsTop9()
        {
            List<Fangor.Model.Articles> result = null;

            result = Factoty.Access<SqlDAO.NewsManageDAO>.Invoke("SelectNewsTop9", new Type[0]) as List<Model.Articles>;

            return result;
        }

        public List<Model.Articles> BaseSelectAll()
        {
            throw new NotImplementedException();
        }

        public int BaseInsert(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }

        public int BaseUpdate(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }

        public int BaseDelete(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }
    }
}
