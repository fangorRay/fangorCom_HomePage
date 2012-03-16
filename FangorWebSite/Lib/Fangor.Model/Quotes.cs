using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.Model
{
    public class Quotes
    {
        private int Quote_Id;

        public int Quote_Id1
        {
            get { return Quote_Id; }
            set { Quote_Id = value; }
        }

        private string Quote_Name;

        public string Quote_Name1
        {
            get { return Quote_Name; }
            set { Quote_Name = value; }
        }

        private int Quote_Type;

        public int Quote_Type1
        {
            get { return Quote_Type; }
            set { Quote_Type = value; }
        }

        private string Quote_Content;

        public string Quote_Content1
        {
            get { return Quote_Content; }
            set { Quote_Content = value; }
        }

        private UserInfo Quote_Writer;

        public UserInfo Quote_Writer1
        {
            get { return Quote_Writer; }
            set { Quote_Writer = value; }
        }

        private DateTime Quote_Time;

        public DateTime Quote_Time1
        {
            get { return Quote_Time; }
            set { Quote_Time = value; }
        }

        private int Quote_Case;

        public int Quote_Case1
        {
            get { return Quote_Case; }
            set { Quote_Case = value; }
        }
    }
}
