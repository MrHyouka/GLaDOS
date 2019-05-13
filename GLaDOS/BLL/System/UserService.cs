using GLaDOS.BLL.Entity;
using GLaDOS.DAL.DBHelper;
using GLaDOS.Properties;
using System.Collections.Generic;

namespace GLaDOS.BLL.System
{
    class UserService
    {
        public static List<UserGroup> GetUserGroupList()
        {
            return DBHelper.ExecuteQueryForList<UserGroup>(SQL.SQL_Select_UserGroupList_Ver_001, null);
        }

        public static List<string> GetUserGroupNameList()
        {
            List<string> userGroupNameList = new List<string>();
            List<UserGroup> userGroups = DBHelper.ExecuteQueryForList<UserGroup>(SQL.SQL_Select_UserGroupList_Ver_001, null);
            if (userGroups != null)
            {
                foreach (UserGroup userGroup in userGroups)
                {
                    userGroupNameList.Add(userGroup.UserGroupName);
                }
            }
            return userGroupNameList;
        }
    }
}
