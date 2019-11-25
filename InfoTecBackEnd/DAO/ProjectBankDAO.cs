using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Interfaces;
using InfoTecBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InfoTecBackEnd.DAO
{
    public class ProjectBankDAO : IProjectBank
    {

        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

        public ProjectBankModel DeleteProject(int project)
        {
            throw new NotImplementedException();
        }

        public List<ProjectBankModel> GetAllProjects()
        {
            List<ProjectBankModel> Projects = new List<ProjectBankModel>();

            SqlCommand cmd = new SqlCommand("Get_All_Project", conn);
            cmd.CommandTimeout = 0;
            // cmd.Parameters.AddWithValue(DataConstant.PARAM_RESOURCE_RESID, id);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            ProjectBankModel project = null;

            while (dr.Read())
            {
                project = new ProjectBankModel();
                project.IdBproy = dr.GetInt32(dr.GetOrdinal("IdBproy"));
                project.tipo_proyecto = dr.GetString(dr.GetOrdinal("tipo_proyecto"));
                project.nombre_proy = dr.GetString(dr.GetOrdinal("nombre_proy"));
                project.nombre_emp = dr.GetString(dr.GetOrdinal("nombre_emp"));
                project.nombre_cont = dr.GetString(dr.GetOrdinal("nombre_cont"));
                project.tel_empre = dr.GetInt32(dr.GetOrdinal("tel_empre"));
                project.correo_empre = dr.GetString(dr.GetOrdinal("correo_empre"));
                project.num_vacantes = dr.GetInt32(dr.GetOrdinal("num_vacantes"));
                project.direccion_empre = dr.GetString(dr.GetOrdinal("direccion_empre"));
                Projects.Add(project);
            }
            conn.Close();
            return Projects;
        }

        public ProjectBankModel GetProjects(int id)
        {
            throw new NotImplementedException();
        }

        public ProjectBankModel UpdateProject(ProjectBankModel order)
        {
            throw new NotImplementedException();
        }
    }
}
