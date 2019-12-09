using InfoTecBackEnd.Model;
using System.Data.SqlClient;
using System.Data;

namespace InfoTecBackEnd.DAO
{
    public class ValidarDAO
    {
        public bool Valida (ProjectModel project, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand("validacionSuscripcion", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@numerodecontrol", project.NoControl);
            cmd.Parameters.AddWithValue("@IdBproy", project.IdBproy);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            bool valida = dr.GetBoolean(dr.GetOrdinal("validacion"));
            conn.Close();
            return valida;    
        }
    }
}