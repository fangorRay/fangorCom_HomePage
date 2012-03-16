using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.Other
{
    public class UserInfoBind
    {
        public Fangor.Model.UserInfo GetBind(SqlDataReader Reader)
        {
            Fangor.Model.UserInfo result = new Model.UserInfo();

            result.User_Id1 = Convert.ToInt32(Reader["User_Id"]);

            result.User_Name1 = Reader["User_Name"].ToString();

            result.User_Type1 = Convert.ToInt32(Reader["User_Type"]);

            result.PassWord1 = Reader["PassWord"].ToString();

            result.Time1 = Convert.ToDateTime(Reader["Time"]);

            return result;
        }
    }
}
