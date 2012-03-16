using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.Other
{
    public class ReplysBind
    {
        public Fangor.Model.Replys GetBind(SqlDataReader Reader)
        {
            Fangor.Model.Replys result = new Model.Replys();

            result.Reply_Id1 = Convert.ToInt32(Reader["Reply_Id"]);

            result.Reply_Content1 = Reader["Reply_Content"].ToString();

            result.Reply_AriticleId1 = Convert.ToInt32(Reader["Reply_ArticleId"]);

            result.Reply_ReContent1 = Reader["Reply_ReContent"].ToString();

            Fangor.Model.UserInfo users = new Fangor.Model.UserInfo();

            users.User_Id1 = Convert.ToInt32(Reader["Reply_ReId"]);

            result.Reply_ReId1 = users;

            result.Reply_Time1 = Convert.ToDateTime(Reader["Reply_Time"]);

            result.Reply_Writer1 = Reader["Reply_Writer"].ToString();

            return result;
        }
    }
}
