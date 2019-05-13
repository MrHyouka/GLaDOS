using GLaDOS.BLL.Entity;
using GLaDOS.BLL.Public;
using GLaDOS.DAL.DBHelper;
using GLaDOS.Properties;
using System;

namespace GLaDOS.BLL.System
{
    public class UserLoginService
    {
        public static bool UserLogin(string user_id, string password)
        {
            User user = DBHelper.ExecuteQueryForObject<User>(SQL.SQL_Select_User_Ver_001, new object[] { user_id });
            if (user != default(User))
            {
                if (user.UserPassword.Equals(password))
                {
                    GlobalInformation.Login_User_Id = user.UserName;
                    GlobalInformation.Login_User_Name = user.UserDesc;
                    GlobalInformation.Login_User_Group = user.UserGroupName;
                    GlobalInformation.Login_Time = DateTime.Now;
                    if(user.UserGroupName!=null && user.UserGroupName!=string.Empty)
                    {
                        UserGroup userGroup = DBHelper.ExecuteQueryForObject<UserGroup>(SQL.SQL_Select_UserGroup_Ver_001, new object[] { user.UserGroupName });
                        GlobalInformation.AuthorityLevel = userGroup.AuthorityLevel;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
