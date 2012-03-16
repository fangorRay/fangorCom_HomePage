using System;
using System.Collections.Generic;
using System.Text;

namespace Fangor.Model
{
    public class UserInfo
    {
        private int User_Id;

        public int User_Id1
        {
            get { return User_Id; }
            set { User_Id = value; }
        }

        private string User_Name;

        public string User_Name1
        {
            get { return User_Name; }
            set { User_Name = value; }
        }

        private string PassWord;

        public string PassWord1
        {
            get { return PassWord; }
            set { PassWord = value; }
        }

        private DateTime Time;

        public DateTime Time1
        {
            get { return Time; }
            set { Time = value; }
        }

        private int User_Type;

        public int User_Type1
        {
            get { return User_Type; }
            set { User_Type = value; }
        }
    }
}
