using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modif_task.access_modifie
{
    class User
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length<= 25 && value.Length >= 6)
                {
                   
                        _userName = value;
                    
                }
            }
        }
        private string _pasword;
        public string Pasword
        {
            get
            {
                return _pasword;
            }
            set
            {
                if (value.Length <= 25 && value.Length >= 8)
                {
                    if (HasDigit(value)==true && HasUpper(value)==true && HasLower(value)==true)
                    {
                     _pasword = value;
                    }
                   
                }
            }
        }
        public bool HasDigit(string value)
        {
            foreach (char item in value)
            {
                if (item>=48 && item<=57 )
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string value)
        {
            foreach (char item in value)
            {
                if (item>=65 && item<=90)
                {
                    return true;
                }
            }
            return false;
        }
        public  bool HasLower(string value)
        {
            foreach (char item in value)
            {
                if (item>=97 && item<=122)
                {
                    return true;
                }
            }
            return false;
        }
        public User()
        {

        }
        public User(string UserName)
        {
            this.UserName = UserName;
        }
        public User(string UserName,string Pasword):this(UserName)
        {
            this.Pasword = Pasword;
        }
    }
}
