using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EvaluationManager
{
    public static class TeacherRepository
    {
        public static Teacher GetTeacher(string username)
        {
            string sql = $"SELECT * FROM Teachers WHERE Username = '{username}'";
            return FetchTeacher(sql);
        }

        public static Teacher GetTeacher(int id)
        {
            string sql = $"SELECT * FROM Teachers WHERE Id = '{id}'";
            return FetchTeacher(sql);
        }

        private static Teacher FetchTeacher(string sql)
        {
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            Teacher teacher = null;


            if (reader.HasRows)
            {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return teacher;
        }


        private static Teacher CreateObject(SqlDataReader reader)
        {
            Teacher teacher = new Teacher();

            teacher.Id = Convert.ToInt32(reader["Id"].ToString());
            teacher.FirstName = reader["FirstName"].ToString();
            teacher.LastName = reader["LastName"].ToString();
            teacher.Username = reader["Username"].ToString();
            teacher.Password = reader["Password"].ToString();

            return teacher;
        }
    }
}
