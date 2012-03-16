using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.Other
{
    public class QuotesBind
    {
        public Fangor.Model.Quotes GetBind(SqlDataReader Reader) {
            Fangor.Model.Quotes result = new Model.Quotes();

            result.Quote_Id1 = Convert.ToInt32(Reader["Quote_Id"]);

            result.Quote_Name1 = Reader["Quote_Name"].ToString();

            result.Quote_Content1 = Reader["Quote_Content"].ToString();

            result.Quote_Case1 = Convert.ToInt32(Reader["Quote_Case"]);

            result.Quote_Time1 = Convert.ToDateTime(Reader["Quote_Time"]);

            result.Quote_Type1 = Convert.ToInt32(Reader["Quote_Type"]);

            Fangor.Model.UserInfo users = new Model.UserInfo();

            users.User_Id1 = Convert.ToInt32(Reader["Quote_Writer"]);

            result.Quote_Writer1 = users;

            return result;
        }
    }
}
