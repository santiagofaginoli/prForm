using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.clases;
public static class Db

    {
    public static DataTable Select(string sql)
        {
            string cadena = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comando;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    public static int Ejecutar(string sql)
    {
        string cadena = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;Trust Server Certificate=True";
        using (SqlConnection con = new SqlConnection(cadena)) 
        using (SqlCommand comando = new SqlCommand(sql, con))
        {
            con.Open();
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }
    }
    // En tu clase Db.cs
    public static object Escalar(string query)
    {
        string cadena = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;Trust Server Certificate=True";
        using (SqlConnection con = new SqlConnection(cadena))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            con.Open();
            return cmd.ExecuteScalar();
        }
    }

}
