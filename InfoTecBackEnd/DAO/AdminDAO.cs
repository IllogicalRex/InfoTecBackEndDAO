using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Model;
using InfoTecBackEnd.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace InfoTecBackEnd.DAO
{
    public class AdminDAO : IAdmin
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        
        public AdminModel GetAdminInfo(string id)
        {
            SqlCommand cmd = new SqlCommand("getInfoAdmin", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            AdminModel admin = null;
            while (dr.Read())
            {
                admin = new AdminModel();
                admin.idadmin = dr.GetString(dr.GetOrdinal("idadmin"));
                admin.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                admin.apellido = dr.GetString(dr.GetOrdinal("apellido"));
                admin.idrol = dr.GetInt32(dr.GetOrdinal("idrol"));
            }
               conn.Close();

        return admin;  
        }
    }
}
