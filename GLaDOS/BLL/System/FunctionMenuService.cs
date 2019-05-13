using System.Collections.Generic;
using System.Data;
using DevComponents.AdvTree;
using GLaDOS.BLL.Entity;
using GLaDOS.DAL.DBHelper;
using GLaDOS.Properties;

namespace GLaDOS.BLL
{
    class FunctionMenuService
    {
        public static List<Function> GetFunctionMenu(string userGroupName)
        {
            userGroupName = userGroupName?.Trim();
            return DBHelper.ExecuteQueryForList<Function>(SQL.SQL_Select_FunctionMenu_Ver_001, new object[] { userGroupName });
        }

        public static Function GetFunction(string functionName)
        {
            functionName?.Trim();
            return DBHelper.ExecuteQueryForObject<Function>(SQL.SQL_Select_Function_Ver_001, new object[] { functionName });
        }

        public static DataTable GetFunctionList(string functionType)
        {
            functionType = functionType?.Trim();
            return DBHelper.ExecuteQuery(SQL.SQL_Select_FunctionList_Ver_001, new object[] { functionType, functionType==string.Empty?null: functionType });
        }

        public static bool CreateFunction(Function function)
        {
            object[] parameters = new object[] { function.FunctionName, function.FunctionDesc, function.FunctionType, function.AssemblyFile, function.AssemblyName };
            if(DBHelper.ExecuteNonQuery(SQL.SQL_Insert_Function_Ver_001, parameters)==0)
            {
                return false;
            }
            return true;
        }

        public static bool DeleteFunction(string functionName)
        {
            functionName=(functionName?.Trim());
            if (DBHelper.ExecuteNonQuery(SQL.SQL_Delete_Function_Ver_001, new object[] { functionName.Trim() }) == 0)
            {
                return false;
            }
            return true;
        }

        public static bool SaveFunctionMenu(NodeCollection menuNodes, string userGroupName)
        {
            try
            {
                DBHelper.BeginTransaction();
                DBHelper.ExecuteNonQueryWithTransaction(SQL.SQL_Delete_FunctionMenu_Ver_001, new object[] { userGroupName });
                if (menuNodes.Count > 0)
                {
                    int functionIndex = 1;
                    foreach (Node node in menuNodes)
                    {
                        Function function = (Function)node.Tag;
                        object[] parameters = new object[] { function.FunctionName, functionIndex, null, userGroupName };
                        if (DBHelper.ExecuteNonQueryWithTransaction(SQL.SQL_Insert_FunctionMenu_Ver_001, parameters) == 0)
                        {
                            DBHelper.RollbackTransaction();
                            return false;
                        }
                        SaveFunctionMenuChild(node.Nodes, function.FunctionName, userGroupName);
                        functionIndex++;
                    }
                }
                DBHelper.CommitTransaction();
                return true;
            }
            catch
            { DBHelper.RollbackTransaction(); throw; }
        }

        private static bool SaveFunctionMenuChild(NodeCollection menuNodes, string parentName, string userGroupName)
        {
            if (menuNodes.Count > 0)
            {
                int functionIndex = 1;
                foreach (Node node in menuNodes)
                {
                    Function function = (Function)node.Tag;
                    object[] parameters = new object[] { function.FunctionName, functionIndex, parentName, userGroupName };
                    if (DBHelper.ExecuteNonQueryWithTransaction(SQL.SQL_Insert_FunctionMenu_Ver_001, parameters) == 0)
                    {
                        DBHelper.RollbackTransaction();
                        return false;
                    }
                    SaveFunctionMenuChild(node.Nodes, function.FunctionName, userGroupName);
                    functionIndex++;
                }
            }
            return true;
        }
    }
}
