using System;

namespace GLaDOS.BLL.Public
{
    class GlobalInformation
    {
        public static string Login_User_Id { get; set; }
        public static string Login_User_Name { get; set; }
        public static string Login_User_Group { get; set; }
        public static DateTime Login_Time{ get; set; }
        public static int AuthorityLevel { get; set; }
    }
}
