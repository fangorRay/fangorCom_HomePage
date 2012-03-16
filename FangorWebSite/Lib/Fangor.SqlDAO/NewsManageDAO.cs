using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Fangor.Other;

namespace Fangor.SqlDAO
{
    public class NewsManageDAO : Fangor.IDAL.INewsManageDAO<Fangor.Model.Articles>, Fangor.IDAL.IBaseDAO<Fangor.Model.Articles>
    {
        Fangor.Other.ArticlesBind articlesBind = new ArticlesBind();

        public List<Model.Articles> SelectNewsTop9()
        {
            List<Fangor.Model.Articles> result = new List<Model.Articles>();

            string Sqls = "Select Top 9 * From Articles Order by Article_Time DESC";

            using (SqlDataReader Reader = DbUtility.SqlHelper.ExecuteReader(Fangor.DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls))
            {
                if (Reader != null)
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            result.Add(articlesBind.GetModel(Reader));
                        }
                    }
                }
            }

            return result;
        }

        public List<Model.Articles> BaseSelectAll()
        {
            List<Model.Articles> result = new List<Model.Articles>();

            String Sqls = "";

            using (SqlDataReader Reader = DbUtility.SqlHelper.ExecuteReader(DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls))
            {
                if (Reader != null)
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            result.Add(articlesBind.GetModel(Reader));
                        }
                    }
                }
            }

            return result;
        }

        public int BaseInsert(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }

        public int BaseUpdate(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }

        public int BaseDelect(Model.Articles Obj)
        {
            throw new NotImplementedException();
        }
    }
}
