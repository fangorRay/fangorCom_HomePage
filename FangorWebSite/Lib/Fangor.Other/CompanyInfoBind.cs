using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fangor.Other
{
    public class CompanyInfoBind
    {
        public Fangor.Model.CompanyInfo GetBind(SqlDataReader Reader)
        {
            Fangor.Model.CompanyInfo result = new Model.CompanyInfo();

            result.Company_Id1 = Convert.ToInt32(Reader["Company_Id"]);

            Fangor.Model.Images image = new Model.Images();

            image.Image_Id1 = Convert.ToInt32(Reader["Company_AddPicture"]);

            result.Company_AddPicture1 = image;

            result.Company_Address1 = Reader["Company_Address"].ToString();

            result.Company_Content1 = Reader["Company_Content"].ToString();

            result.Company_Email1 = Reader["Company_Email"].ToString();

            image.Image_Id1 = Convert.ToInt32(Reader["Company_Logo"]);

            result.Company_Logo1 = image;

            result.Company_QQ1 = Reader["Company_QQ"].ToString();

            result.Company_Tel1 = Reader["Company_Tel"].ToString();

            result.Company_Time1 = Convert.ToDateTime(Reader["Company_Time"]);

            result.Company_Type1 = Reader["Company_Type"].ToString();

            result.Company_Writer1 = Reader["Company_Writer"].ToString();

            return result;
        }
    }
}
