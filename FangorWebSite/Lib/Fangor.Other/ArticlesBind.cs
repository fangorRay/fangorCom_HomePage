using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Fangor.Other
{
    public class ArticlesBind
    {
        public String GetUserNameById(int Id)
        {
            string result = "";

            String Sqls = "Select User_Name From UserInfo Where User_Id = " + Id;

            result = Fangor.DbUtility.SqlHelper.ExecuteScalar(DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls).ToString();

            return result;
        }

        public Fangor.Model.Articles GetModel(SqlDataReader Reader)
        {
            Fangor.Model.Articles result = new Model.Articles();

            result.Article_Id1 = Convert.ToInt32(Reader["Article_Id"].ToString());

            result.Article_Title1 = Reader["Article_Title"].ToString();

            Fangor.Model.UserInfo users = new Fangor.Model.UserInfo();

            users.User_Name1 = GetUserNameById(Convert.ToInt32(Reader["Article_Writer"]));

            result.Article_Writer1 = users;

            //result.Article_Writer1.User_Id1 = Convert.ToInt32(Reader["Article_Writer"]);

            result.Article_Content1 = Reader["Article_Content"].ToString();

            result.Article_Time1 = Convert.ToDateTime(Reader["Article_Time"]);

            result.Article_Top1 = Convert.ToInt32(Reader["Article_Top"]);

            result.Article_Type1 = Convert.ToInt32(Reader["Article_Type"]);

            result.Article_Click1 = Convert.ToInt32(Reader["Article_Click"]);

            result.Article_Type1 = Convert.ToInt32(Reader["Article_Type"]);

            result.Article_Time1 = Convert.ToDateTime(Reader["Article_Time"]);

            result.Article_Reply1 = Convert.ToInt32(Reader["Article_Reply"]);

            result.Article_Red1 = Convert.ToInt32(Reader["Article_Red"]);

            if (result.Article_Type1 == 1)
            {
                Fangor.Model.Images Images = new Fangor.Model.Images();

                Images.Image_Url1 = GetImagePathById(Convert.ToInt32(Reader["Article_Picture"]));

                result.Article_Picture1 = Images;
            }

            return result;
        }

        private string GetImagePathById(int Id)
        {
            String result = "";

            string Sqls = "Select Image_Url From Images Where Image_Id =" + Id;

            result = Fangor.DbUtility.SqlHelper.ExecuteScalar(DbUtility.SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, Sqls).ToString();

            return result;
        }
    }
}
