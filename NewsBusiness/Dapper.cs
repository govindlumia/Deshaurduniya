using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Business
{
    public class Dapper
    {
        private static string connectionstring = ConfigurationManager.ConnectionStrings["NewsConnectionString"].ConnectionString;

        public static void ExecuteWithoutReturn(string ProcedureName, DynamicParameters param)
        {
            using (SqlConnection Con = new SqlConnection(connectionstring))
            {
                Con.Open();
                Con.Execute(ProcedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        //Dapper.ExecuteReturnScalar<int>('','');
        public static T ExecuteReturnScalar<T>(string ProcedureName, DynamicParameters param)
        {
            using (SqlConnection Con = new SqlConnection(connectionstring))
            {
                Con.Open();
                return (T)Convert.ChangeType(Con.Execute(ProcedureName, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }
        //===return int type or single value
        public static T ReturnSingleValue<T>(string storeProcedure, DynamicParameters param)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                return conn.Query<T>(storeProcedure, param, commandType: CommandType.StoredProcedure).Single();
            }
        }

        //DapperORM.ReturnList<EmployeeModel> <= IEnumerable<EmployeeModel>
        public static IEnumerable<T> ReturnList<T>(string ProcedureName, DynamicParameters param)
        {
            using (SqlConnection Con = new SqlConnection(connectionstring))
            {
                Con.Open();
                return Con.Query<T>(ProcedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public static List<T> ReturnListType<T>(string storeProcedure, DynamicParameters param)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                return conn.Query<T>(storeProcedure, param, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static T ReturnSingleRow<T>(string storeProcedure, DynamicParameters param)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                return conn.Query<T>(storeProcedure, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        //DapperORM.DataSet<DataSet>('',''); 
        public static T DataSet<T>(string ProcedureName, DynamicParameters param)
        {
            using (SqlConnection Con = new SqlConnection(connectionstring))
            {
                Con.Open();
                return (T)Convert.ChangeType(Con.Execute(ProcedureName, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }
    }
}
