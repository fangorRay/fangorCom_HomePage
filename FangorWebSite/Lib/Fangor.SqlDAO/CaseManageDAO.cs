using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fangor.SqlDAO
{
    public class CaseManageDAO : Fangor.IDAL.ICaseManageDAO<Fangor.Model.Articles>, Fangor.IDAL.IBaseDAO<Fangor.Model.Articles>
    {
        public List<Model.Articles> SelectTop2()
        {
            List<Fangor.Model.Articles> result = new List<Model.Articles>();

            String Sqls = "Select Top 2 * From Articles Order By Article_Time DESC";

            using (SqlDataReader Reader = Fangor.DbUtility.SqlHelper.ExecuteReader(DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls))
            {
                if (Reader != null)
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            result.Add(GetModel(Reader));
                        }
                    }
                }
            }

            return result;
        }

        public Fangor.Model.Articles GetModel(SqlDataReader Reader)
        {
            Fangor.Model.Articles result = new Model.Articles();

            result.Article_Id1 = Convert.ToInt32(Reader["Article_Id"]);

            result.Article_Title1 = Reader["Article_Title"].ToString();

            result.Article_Content1 = Reader["Article_Content"].ToString();

            result.Article_Top1 = Convert.ToInt32(Reader["Article_Top1"]);

            result.Article_Click1 = Convert.ToInt32(Reader["Article_Click1"]);

            result.Article_Writer1.User_Id1 = Convert.ToInt32(Reader["Article_Writer"]);



            return result;
        }

        public List<Model.Articles> BaseSelectAll()
        {
            List<Model.Articles> result = new List<Model.Articles>();

            string Sqls = "";

            using (SqlDataReader Reader = DbUtility.SqlHelper.ExecuteReader(DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls))
            {
                if (Reader != null)
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            result.Add(GetModel(Reader));
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
