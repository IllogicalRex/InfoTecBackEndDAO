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

        public string DeleteProject(int projectid)
        {
            SqlCommand cmd = new SqlCommand("Delete_ProjectBank", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("IdBproy", projectid);

            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Projecto eliminado";
        }

        public List<ProjectBankModel> GetAllProjects()
        {
            List<ProjectBankModel> Projects = new List<ProjectBankModel>();

            SqlCommand cmd = new SqlCommand("Get_all_proyectos", conn);
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

        public string CreateProject(ProjectBankModel value)
        {
            SqlCommand cmd = new SqlCommand("Create_ProjectBank", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("tipo_proyecto", value.tipo_proyecto);
            cmd.Parameters.AddWithValue("nombre_proy", value.nombre_proy);
            cmd.Parameters.AddWithValue("nombre_emp", value.nombre_emp);
            cmd.Parameters.AddWithValue("nombre_cont", value.nombre_cont);
            cmd.Parameters.AddWithValue("tel_empre", value.tel_empre);
            cmd.Parameters.AddWithValue("correo_empre", value.correo_empre);
            cmd.Parameters.AddWithValue("num_vacantes", value.num_vacantes);
            cmd.Parameters.AddWithValue("direccion_empre", value.direccion_empre);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Se creo el proyecto correctamente";
        }

        public ProjectBankModel GetProjectsById(int id)
        {
            SqlCommand cmd = new SqlCommand("Get_all_proyectosById", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("IdBproy", id);
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
            }
            conn.Close();
            return project;
        }

        public ProjectBankModel UpdateProject(int id, ProjectBankModel order)
        {
            SqlCommand cmd = new SqlCommand("Update_ProjectBank", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("IdBproy", id);
            cmd.Parameters.AddWithValue("tipo_proyecto", order.tipo_proyecto);
            cmd.Parameters.AddWithValue("nombre_proy", order.nombre_proy);
            cmd.Parameters.AddWithValue("nombre_emp", order.nombre_emp);
            cmd.Parameters.AddWithValue("nombre_cont", order.nombre_cont);
            cmd.Parameters.AddWithValue("tel_empre", order.tel_empre);
            cmd.Parameters.AddWithValue("correo_empre", order.correo_empre);
            cmd.Parameters.AddWithValue("num_vacantes", order.num_vacantes);
            cmd.Parameters.AddWithValue("direccion_empre", order.direccion_empre);

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
            }
            conn.Close();
            return project;
        }
    }
}
