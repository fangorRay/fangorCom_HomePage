using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    public List<Fangor.Model.Articles> ArticleResults;

    public int QQnum;

    protected void Page_Load(object sender, EventArgs e)
    {
        List<Fangor.Model.Articles> ArticleResult = null;

        ArticleResult = Fangor.Factoty.Access<Fangor.BllBiz.NewsManageService>.Invoke("SelectNewsTop9", new Type[0]) as List<Fangor.Model.Articles>;

        ArticleResults = ArticleResult;

        QQnum = 602657028;
    }
}