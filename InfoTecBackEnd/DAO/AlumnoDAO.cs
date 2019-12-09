using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Model;
using InfoTecBackEnd.interfaces;
using System.Data.SqlClient;
using System.Data;

namespace InfoTecBackEnd.DAO
{

    public class AlumnoDAO : IAlumno
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        public AlumnoModel getAlumno(string id)
        {
            SqlCommand cmd = new SqlCommand("infoAlumno", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            AlumnoModel alumno = null;

            while (dr.Read())
            {
                alumno = new AlumnoModel();
                alumno.alumnoId = dr.GetString(dr.GetOrdinal("NumeroDeControl"));
                alumno.nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                alumno.apellido = dr.GetString(dr.GetOrdinal("Apellido"));
                alumno.telefono = dr.GetString(dr.GetOrdinal("telefono"));
                alumno.carrera = dr.GetString(dr.GetOrdinal("carrera"));
                alumno.sexo = dr.GetString(dr.GetOrdinal("sexo"));
                alumno.correo = dr.GetString(dr.GetOrdinal("correo"));
                alumno.plan_estudio = dr.GetString(dr.GetOrdinal("plan_estudio"));
                alumno.mod_especialidad = dr.GetString(dr.GetOrdinal("mod_especialidad"));
                alumno.sit_vigencia = dr.GetString(dr.GetOrdinal("sit_vigencia"));
                alumno.promedio = dr.GetDecimal(dr.GetOrdinal("promedio"));
                alumno.creditos_acumulados = dr.GetInt32(dr.GetOrdinal("creditos_acumulados"));
                alumno.periodo_ingreso = dr.GetString(dr.GetOrdinal("periodo_ingreso"));
                alumno.periodo_convalidado = dr.GetInt32(dr.GetOrdinal("periodo_convalidado"));
                alumno.periodo_actual_ultimo = dr.GetString(dr.GetOrdinal("periodo_actual_ultimo"));
                alumno.tutor = dr.GetString(dr.GetOrdinal("asesor"));
                alumno.curp = dr.GetString(dr.GetOrdinal("curp"));
                alumno.fecha_naci = dr.GetDateTime(dr.GetOrdinal("fecha_naci"));
                alumno.direccion = dr.GetString(dr.GetOrdinal("direccion"));
                alumno.escuela_procedencia = dr.GetString(dr.GetOrdinal("escuela_procedencia"));
                alumno.nombreProyecto = dr.GetString(dr.GetOrdinal("NombreProyecto"));
            }                        
            conn.Close();

            return alumno;
        }
    }
}