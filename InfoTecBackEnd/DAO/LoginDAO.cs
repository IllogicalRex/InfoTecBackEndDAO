using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTecBackEnd.DAO
{
    public class LoginDAO
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

        public LoginModel GetUserAlumn(LoginModel user)
        {
            SqlCommand cmd = new SqlCommand("GetUserAlumno", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("userName", user.userName);
            cmd.Parameters.AddWithValue("password", user.password);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            LoginModel userResponse = null;

            while (dr.Read())
            {
                userResponse = new LoginModel();
                userResponse.userName = dr.GetString(dr.GetOrdinal("userName"));
                userResponse.password = dr.GetString(dr.GetOrdinal("password"));
                
            }
            conn.Close();
            return userResponse;
        }

        public LoginModel GetUserAsesor(LoginModel user)
        {
            SqlCommand cmd = new SqlCommand("GetUserAsesor", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("userName", user.userName);
            cmd.Parameters.AddWithValue("password", user.password);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            LoginModel userResponse = null;

            while (dr.Read())
            {
                userResponse = new LoginModel();
                userResponse.userName = dr.GetString(dr.GetOrdinal("userName"));
                userResponse.password = dr.GetString(dr.GetOrdinal("password"));

            }
            conn.Close();
            return userResponse;
        }

        public LoginModel GetUserEncargado(LoginModel user)
        {
            SqlCommand cmd = new SqlCommand("GetUserEncargado", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("userName", user.userName);
            cmd.Parameters.AddWithValue("password", user.password);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            LoginModel userResponse = null;

            while (dr.Read())
            {
                userResponse = new LoginModel();
                userResponse.userName = dr.GetString(dr.GetOrdinal("userName"));
                userResponse.password = dr.GetString(dr.GetOrdinal("password"));

            }
            conn.Close();
            return userResponse;
        }
    }
}
