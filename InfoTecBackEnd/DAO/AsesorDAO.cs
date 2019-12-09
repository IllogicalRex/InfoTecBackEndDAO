using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Model;
using InfoTecBackEnd.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace InfoTecBackEnd.DAO
{
    public class AsesorDAO: IAsesor 
    {   
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        public AsesorModel getAsesor(string id)
        {
            
            SqlCommand cmd = new SqlCommand("getAsesor", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            AsesorModel asesor = null;
            while (dr.Read())
            {
                asesor = new AsesorModel();
                asesor.IdAsesor = dr.GetString(dr.GetOrdinal("Idasesor"));
                asesor.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                asesor.apellido = dr.GetString(dr.GetOrdinal("apellido"));
                asesor.correo_electronico = dr.GetString(dr.GetOrdinal("correo_electronico"));
                asesor.telefono = dr.GetString(dr.GetOrdinal("telefono"));
                asesor.idrol = dr.GetInt32(dr.GetOrdinal("idrol"));
            }                        
            conn.Close();

            return asesor;

    

        }
    }       
}