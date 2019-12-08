using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Interfaces;
using InfoTecBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InfoTecBackEnd.DAO
{
    public class EmpresaDAO:IEmpresa{
    SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        public string deleteEmpresa(int id)
        {
            SqlCommand cmd = new SqlCommand("deleteEmpresa", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("id", id);

            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Projecto eliminado";

        }

        public string postEmpresa(EmpresaModel empresa) 
        {
            SqlCommand cmd = new SqlCommand("Create_ProjectBank", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("nombre", empresa.nombre);
            cmd.Parameters.AddWithValue("direccion", empresa.direccion);
            cmd.Parameters.AddWithValue("correo_electronico",empresa.correo_electronico);
            cmd.Parameters.AddWithValue("telefono",empresa.telefono);
            cmd.Parameters.AddWithValue("1",empresa.Idrol);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Se creo el proyecto correctamente";
        }
        public List<EmpresaModel> getAllEmpresas()
        {
            List<EmpresaModel> empresas = new List<EmpresaModel>();
            SqlCommand cmd = new SqlCommand("getAllEmpresas", conn);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            EmpresaModel empresa = null;

            while (dr.Read())
            {
                empresa = new EmpresaModel();
                empresa.Idempresa = dr.GetInt32(dr.GetOrdinal("Idempresa"));
                empresa.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                empresa.direccion = dr.GetString(dr.GetOrdinal("direccion"));
                empresa.correo_electronico = dr.GetString(dr.GetOrdinal("correo_electronico"));
                empresa.telefono = dr.GetInt32(dr.GetOrdinal("telefono"));

                
                empresas.Add(empresa);
            }    
            return empresas;
        }   
    }      

}