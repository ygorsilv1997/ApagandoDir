using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ApagarDir.NewFolder1;

namespace ApagarDir.DAO
{
    class GetSolicitacoes
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public List<String> GetSol()
        {
            List<String> solicitacoes = new List<String>();
     
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT SEN_ID FROM DV_SOL ");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql.ToString();
                cmd.Connection = conn;

                SqlDataReader leitor = cmd.ExecuteReader();


                while (leitor.Read())
                {            
                    solicitacoes.Add(leitor["SEN_ID"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                conn.Close();
            }

            return solicitacoes;
        }

        public String GetDirAnexo()
        {
            String dirAnexo="";

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT DIR_SOL FROM DV_SOL_DIR");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql.ToString();
                cmd.Connection = conn;

                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read()) {
                    dirAnexo = leitor["DIR_SOL"].ToString();
                }
                

                conn.Close();
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                conn.Close();
            }
            return dirAnexo;
        }
    }
}

