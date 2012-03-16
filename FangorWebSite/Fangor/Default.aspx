<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>首页</title>
    <meta content="IE=edge,chrome=1" http-equiv="X-UA-Compatible" />
    <meta content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0"
        name="viewport" />
    <link href="./css/unoslider_themes/square/theme.css" id="this" rel="stylesheet" />
    <script type="text/javascript" src="./javascripts/jquery.min.js">
    </script>
    <script type="text/javascript" src="./javascripts/jquery-ui.min.js">
    </script>
    <!--[if lt IE 9]><script type="text/javascript" src="//html5shiv.googlecode.com/svn/trunk/html5.js">
		</script>
		<script type="text/javascript" src="http://css3-mediaqueries-js.googlecode.com/svn/trunk/css3-mediaqueries.js">
		</script><![endif]-->
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
    <div class="headerbg">
        <div class="header">
            <div class="header_center">
                <a href="#" class="logo"></a>
                <div class="navbar">
                    <div class="menuitems">
                        <a href="#">首页</a>
                        <p>
                            HOME</p>
                    </div>
                    <div class="menuitems_line">
                    </div>
                    <div class="menuitems">
                        <a href="#">服务</a>
                        <p>
                            SERVICE</p>
                    </div>
                    <div class="menuitems_line">
                    </div>
                    <div class="menuitems">
                        <a href="#">实力展示</a>
                        <p>
                            CASES</p>
                    </div>
                    <div class="menuitems_line">
                    </div>
                    <div class="menuitems">
                        <a href="#">联系方式</a>
                        <p>
                            CONTACT</p>
                    </div>
                    <div class="menuitems_line">
                    </div>
                    <div class="menuitems">
                        <a href="#">关于泛古</a>
                        <p>
                            ABOUT</p>
                    </div>
                </div>
                <div class="navbar_contact">
                    <p class="fontgray fontalign_right">
                        <span class="font11px">服务热线：</span><span class="font18px fontblue fontverical_middle">028-88888888</span>
                    </p>
                </div>
                <div class="navbar_weibo">
                    <div class="icon_weibo">
                    </div>
                    <p class="font11px">
                        官方微博</p>
                </div>
                <div class="navbar_desc">
                    <p>
                        <span class="font18px"><b>泛古互动</b></span><span class="font14px"> 是一家专注于高端设计的网站建设服务团队<br />
                            我们能提供客户最具有视觉冲击力以及品牌影响力的高端国际化建站服务 </span>
                    </p>
                </div>
            </div>
            <!-- <div class="navbarbg"></div> -->
        </div>
        <div class="navbarbg">
        </div>
    </div>
    <div class="body">
        <div class="slider">
            <ul class="unoslider" id="frontpage_slider">
                <li>
                    <img alt="preview1" src="./images/slides/preview1.jpg" /></li>
                <li>
                    <img alt="preview2" src="./images/slides/preview2.jpg" /></li>
                <!-- <li>
					<div class="unoslider_caption">
						<div class="html_example">
							<h3>Advanced HTML caption</h3>
							You can put any html to your captions.
						</div>
					</div> <a href="about:blank" target="_blank"> <img
						src="./images/slides/preview1.jpg" /></a>
				</li>
				<li>
					<div class="unoslider_layers">
						<div class="l_look slide_top">Oh, look!</div>
						<div class="l_can slide_bottom">I can animate layers</div>
						<div class="l_i slide_right">I</div>
						<div class="l_unoslider slide_left">UnoSlider</div>
					</div> <a href="about:blank" target="_blank"> <img
						src="./images/slides/preview3.jpg" /></a>
				</li> -->
            </ul>
            <script type="text/javascript" src="./javascripts/unoslider_defaults.js"></script>
        </div>
        <script type="text/javascript" src="./javascripts/unoslider.js">
        </script>
        <script type="text/javascript" src="./javascripts/main.js">
        </script>
        <div class="cases">
            <ul>
                <li class="logo_small" />
                <li class="font16px">案例展示<span class="font14px fontgray">&nbsp;&nbsp;&nbsp;<span
                    class="font10px fontgray">|</span>&nbsp;&nbsp;&nbsp;Cases </span></li>
            </ul>
            <div class="cases_more">
                <div class="radius_corner">
                </div>
                <a href="#" class="font12px fontalign_right ">更多案例 +</a>
                <div class="radius_corner">
                </div>
            </div>
            <div class="case_image">
                <img alt="case1" src="images/case1.png" />
            </div>
            <div class="case_description">
                <p class="font16px" style="line-height: 20px">
                    <b>旅游景区互动网站设计－苏州太湖景区创5A互动数字创意</b>
                </p>
                <p class="font12px">
                    苏州太湖旅游发展集团有限公司是由吴中区组建，为全面提升吴中环太湖景区大概豆腐干山东分公司的...</p>
            </div>
            <div class="case_image">
                <img alt="case2" src="images/case2.png" />
            </div>
            <div class="case_description">
                <p class="font16px">
                    <b>旅游景区互动网站设计－苏州太湖景区创5A互动数字创意</b>
                </p>
                <p class="font12px">
                    苏州太湖旅游发展集团有限公司是由吴中区组建，为全面提升吴中环太湖景区...</p>
            </div>
        </div>
        <div class="news">
            <div class="news_more">
                <div class="radius_corner">
                </div>
                <a href="#" class="font12px">+ 更多新闻</a>
                <div class="radius_corner">
                </div>
            </div>
            <ul class="news_list">
                <%
                    foreach (Fangor.Model.Articles items in ArticleResults)
                    {
                        string Title = "";

                        if (items.Article_Title1.Length >= 18)
                        {
                            Title = items.Article_Title1.Substring(0, 15) + "...";
                        }
                        else
                        {
                            Title = items.Article_Title1.ToString();
                        }
                %>
                <li><a class="news_list_content" href="#" title="<%=items.Article_Title1 %>">
                    <%=Title%></a>
                    <p class="news_list_date">
                        <%=items.Article_Time1.ToShortDateString() %></p>
                </li>
                <%} %>
                <%--                <li><a class="news_list_content" href="#">中国浙江国际科技合作交流大会WEB</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">电影《敏感事件》媒体见面会正式召开</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">国家“十一五”重点项目浙江省农居防</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">预祝“第五届中国国际动漫节”圆满成</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">祝第七届“中国·浙江留学人员和科技</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">国家“十一五”重点项目浙江省农居防</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">预祝“第五届中国国际动漫节”圆满成</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>
                <li><a class="news_list_content" href="#">祝第七届“中国·浙江留学人员和科技</a>
                    <p class="news_list_date">
                        2012-11-12</p>
                </li>--%>
            </ul>
        </div>
        <div class="contact">
            <div class="contact_column">
                <div class="contact_column_row">
                    <div class="icon_qq">
                    </div>
                    <div>
                        <p>
                        123456
                        </p>
                    </div>
                </div>
                <div class="contact_column_row">
                    <div class="icon_qq">
                    </div>
                    <div>
                        <p>
                            <a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=506454342&site=qq&menu=yes"><img border="0" src="http://wpa.qq.com/pa?p=2:506454342:43" alt="点击这里给我发消息" title="点击这里给我发消息"></a></p>
                    </div>
                </div>
            </div>
            <div class="contact_column">
                <div class="contact_column_row">
                    <div class="icon_phone">
                    </div>
                    <div>
                        <p>
                            028-<span class="fontblue"><i>12345678</i></span>
                        </p>
                    </div>
                </div>
                <div class="contact_column_row">
                    <div class="icon_mail">
                    </div>
                    <div>
                        <p>
                            kitty6540@163.com</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="bottomlinks">
            <div class="bottomlinks_content">
                <div class="bottomlinks_item">
                    <div class="bottomlinks_item_image">
                        <img alt="price1" src="./images/bottomlinks_img1.png" />
                    </div>
                    <div class="bottomlinks_item_title">
                        <img alt="price_title1" src="./images/bottomlinks_title1.png" />
                    </div>
                    <div class="bottomlinks_item_subtitle">
                        <p class="font12px fontgray fontalign_center">
                            Web design</p>
                    </div>
                    <div class="bottomlinks_item_price">
                        <div class="radius_corner">
                        </div>
                        <a href="#" class="font12px fontwhite fontalign_right ">报价 &gt;</a>
                        <div class="radius_corner">
                        </div>
                    </div>
                    <div class="bottomlinks_item_desc">
                        <p>
                            专业网站建设团队为您提供优质的网络建设服务......</p>
                    </div>
                </div>
                <div class="bottomlinks_line">
                </div>
                <div class="bottomlinks_item">
                    <div class="bottomlinks_item_image">
                        <img alt="price2" src="./images/bottomlinks_img2.png" />
                    </div>
                    <div class="bottomlinks_item_title">
                        <img alt="price_title2" src="./images/bottomlinks_title2.png" />
                    </div>
                    <div class="bottomlinks_item_subtitle">
                        <p class="font12px fontgray fontalign_center">
                            Web set</p>
                    </div>
                    <div class="bottomlinks_item_price">
                        <div class="radius_corner">
                        </div>
                        <a href="#" class="font12px fontwhite fontalign_right ">报价 &gt;</a>
                        <div class="radius_corner">
                        </div>
                    </div>
                    <div class="bottomlinks_item_desc">
                        <p>
                            专业网站建设团队为您提供优质的网络建设服务......</p>
                    </div>
                </div>
                <div class="bottomlinks_line">
                </div>
                <div class="bottomlinks_item">
                    <div class="bottomlinks_item_image">
                        <img alt="price3" src="./images/bottomlinks_img3.png" />
                    </div>
                    <div class="bottomlinks_item_title">
                        <img alt="price_title3" src="./images/bottomlinks_title3.png" />
                    </div>
                    <div class="bottomlinks_item_subtitle">
                        <p class="font12px fontgray fontalign_center">
                            Flash design</p>
                    </div>
                    <div class="bottomlinks_item_price">
                        <div class="radius_corner">
                        </div>
                        <a href="#" class="font12px fontwhite fontalign_right ">报价 &gt;</a>
                        <div class="radius_corner">
                        </div>
                    </div>
                    <div class="bottomlinks_item_desc">
                        <p>
                            专业网站建设团队为您提供优质的网络建设服务......</p>
                    </div>
                </div>
                <div class="bottomlinks_line">
                </div>
                <div class="bottomlinks_item">
                    <div class="bottomlinks_item_image">
                        <img alt="price4" src="./images/bottomlinks_img4.png" />
                    </div>
                    <div class="bottomlinks_item_title">
                        <img alt="price_title4" src="./images/bottomlinks_title4.png" />
                    </div>
                    <div class="bottomlinks_item_subtitle">
                        <p class="font12px fontgray fontalign_center">
                            Logo design</p>
                    </div>
                    <div class="bottomlinks_item_price">
                        <div class="radius_corner">
                        </div>
                        <a href="#" class="font12px fontwhite fontalign_right ">报价 &gt;</a>
                        <div class="radius_corner">
                        </div>
                    </div>
                    <div class="bottomlinks_item_desc">
                        <p>
                            专业网站建设团队为您提供优质的网络建设服务......</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="footer">
        <div class="footer_background">
            <div class="footer_center">
                <a class="logo_bottom"></a>
                <div class="footer_navbar">
                    <ul class="footer_menuitems">
                        <li><a href="#">首页</a> </li>
                        <li><a href="#">服务</a> </li>
                        <li><a href="#">实力展示</a> </li>
                        <li><a href="#">联系方式</a> </li>
                        <li><a href="#">关于泛古</a> </li>
                    </ul>
                </div>
                <div class="footer_line">
                </div>
                <p class="footer_address">
                    成都市一环路东五段108号东恒国际一区一单元1087<br />
                    Tel. 028-12345678<br />
                    Fax. 02-6541-7487<br />
                    Mail. <a href="mailto:admin@vitamind.com">admin@vitamind.com</a></p>
            </div>
        </div>
    </div>
</body>
</html>
