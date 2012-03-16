using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.Other
{
    public class ImagesBind
    {
        public Fangor.Model.Images GetBind(SqlDataReader Reader)
        {
            Fangor.Model.Images result = new Model.Images();

            result.Image_Id1 = Convert.ToInt32(Reader["Image_Id"]);

            result.Image_ArticleId1 = Convert.ToInt32(Reader["Image_ArticleId"]);

            result.Image_LinkUrl1 = Reader["Image_LinkUrl"].ToString();

            result.Image_Time1 = Convert.ToDateTime(Reader["Image_Time"]);

            result.Image_Title1 = Reader["Image_Title1"].ToString();

            result.Image_Top1 = Convert.ToInt32(Reader["Image_Top"]);

            result.Image_Url1 = Reader["Image_Url"].ToString();

            return result;
        }
    }
}
