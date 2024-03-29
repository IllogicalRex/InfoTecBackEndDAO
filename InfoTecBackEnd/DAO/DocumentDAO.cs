﻿using InfoTecBackEnd.Heltper;
using InfoTecBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InfoTecBackEnd.DAO
{
    public class DocumentDAO
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

        public string DeleteDocument(int projectid)
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

        public string CreateDocument(DocumentModel value)
        {
            SqlCommand cmd = new SqlCommand("CreateDocuments", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("AlumnId", value.AlumnId);
            cmd.Parameters.AddWithValue("Idtipo", value.Idtipo);
            cmd.Parameters.AddWithValue("url", value.url);
            cmd.Parameters.AddWithValue("fecha", value.fecha);
            cmd.Parameters.AddWithValue("ComentarioAsesor", value.ComentarioAsesor);
            cmd.Parameters.AddWithValue("idEstatus", value.idEstatus);
            cmd.Parameters.AddWithValue("ComentarioAdmRes", value.ComentarioAdmRes);
            cmd.Parameters.AddWithValue("Idasesor", value.Idasesor);
            cmd.Parameters.AddWithValue("idadmin", value.idadmin);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Se creo el Document correctamente";
        }
        public string UpdateDocument(DocumentModel value)
        {
            SqlCommand cmd = new SqlCommand("UpdateDocuments", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@AlumnId", value.AlumnId);
            cmd.Parameters.AddWithValue("@Idtipo", value.Idtipo);
            cmd.Parameters.AddWithValue("@url", value.url);
            cmd.Parameters.AddWithValue("@fecha", value.fecha);
            cmd.Parameters.AddWithValue("@ComentarioAsesor", value.ComentarioAsesor);
            cmd.Parameters.AddWithValue("@idEstatus", value.idEstatus);
            cmd.Parameters.AddWithValue("@ComentarioAdmRes", value.ComentarioAdmRes);
            cmd.Parameters.AddWithValue("@Idasesor", value.Idasesor);
            cmd.Parameters.AddWithValue("@idadmin", value.idadmin);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return "Se actualizo el Document correctamente";
        }

        public List<DocumentModel> getDocumento(string id)
        {
            List<DocumentModel> documents = new List<DocumentModel>();
            SqlCommand cmd = new SqlCommand("getDocumento", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@AlumnoNumControl", id);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DocumentModel documento = null;

            while (dr.Read())
            {
                documento = new DocumentModel();
                documento.AlumnId = dr.GetString(dr.GetOrdinal("AlumnoId"));
                documento.Idtipo = dr.GetInt32(dr.GetOrdinal("Idtipo"));
                documento.url = dr.GetString(dr.GetOrdinal("url"));
                documento.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                documento.ComentarioAsesor = dr.GetString(dr.GetOrdinal("ComentarioAsesor"));
                documento.idEstatus = dr.GetInt32(dr.GetOrdinal("idEstatus"));
                documento.ComentarioAdmRes = dr.GetString(dr.GetOrdinal("ComentarioAdmRes"));
                documento.Idasesor = dr.GetString(dr.GetOrdinal("Idasesor"));
                documento.idadmin = dr.GetString(dr.GetOrdinal("idadmin"));
                documents.Add(documento);

            }
            conn.Close();

            return documents;
        }
        public List<DocumentModel> getDocumentoAlumnoAsesor(string id)
        {
            List<DocumentModel> documents = new List<DocumentModel>();
            SqlCommand cmd = new SqlCommand("getDocumentoAlumnoAsesor", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@AsesorId", id);
            cmd.Parameters.AddWithValue("@repor1", 3);
            cmd.Parameters.AddWithValue("@repor2", 4);
            cmd.Parameters.AddWithValue("@repor3", 5);
            cmd.Parameters.AddWithValue("@reporFinal", 7);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DocumentModel documento = null;

            while (dr.Read())
            {
                documento = new DocumentModel();
                documento.AlumnId = dr.GetString(dr.GetOrdinal("AlumnoId"));
                documento.Idtipo = dr.GetInt32(dr.GetOrdinal("Idtipo"));
                documento.url = dr.GetString(dr.GetOrdinal("url"));
                documento.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                documento.ComentarioAsesor = dr.GetString(dr.GetOrdinal("ComentarioAsesor"));
                documento.idEstatus = dr.GetInt32(dr.GetOrdinal("idEstatus"));
                documento.ComentarioAdmRes = dr.GetString(dr.GetOrdinal("ComentarioAdmRes"));
                documento.Idasesor = dr.GetString(dr.GetOrdinal("Idasesor"));
                documento.idadmin = dr.GetString(dr.GetOrdinal("idadmin"));
                documents.Add(documento);
            }
            conn.Close();

            return documents;
        }
        public List<DocumentModel> getDocumentoEncargado(string id)
        {
            List<DocumentModel> documents = new List<DocumentModel>();
            SqlCommand cmd = new SqlCommand("getDocumentoEncargado", conn);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@EncargadoId", id);
            cmd.Parameters.AddWithValue("@tipoAcept", 1);
            cmd.Parameters.AddWithValue("@tipoAnte", 2);
            cmd.Parameters.AddWithValue("@tipoSegui", 6);
            cmd.Parameters.AddWithValue("@tipoReport", 7);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DocumentModel documento = null;

            while (dr.Read())
            {
                documento = new DocumentModel();
                documento.AlumnId = dr.GetString(dr.GetOrdinal("AlumnoId"));
                documento.Idtipo = dr.GetInt32(dr.GetOrdinal("Idtipo"));
                documento.url = dr.GetString(dr.GetOrdinal("url"));
                documento.fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
                documento.ComentarioAsesor = dr.GetString(dr.GetOrdinal("ComentarioAsesor"));
                documento.idEstatus = dr.GetInt32(dr.GetOrdinal("idEstatus"));
                documento.ComentarioAdmRes = dr.GetString(dr.GetOrdinal("ComentarioAdmRes"));
                documento.Idasesor = dr.GetString(dr.GetOrdinal("Idasesor"));
                documento.idadmin = dr.GetString(dr.GetOrdinal("idadmin"));
                documents.Add(documento);
            }
            conn.Close();

            return documents;
        }

    }
}
