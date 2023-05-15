using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLocalof
{
    public class LocalDAO
    {
        private SqlConnection Connection { get; }
        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(LocalModel local)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibLocal(descLocal) VALUES (@descricao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@descricao", local.descricao));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Excluir(LocalModel local, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibLocal WHERE codLocal = @local");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@local", local.codLocal));
                command.ExecuteNonQuery();
            }
        }
        public List<LocalModel> GetLocais()
        {
            List<LocalModel> locais = new List<LocalModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT LOC.codLocal, LOC.descLocal FROM mvtBibLocal LOC");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(PopulateDr(dr));
                    }
                }
            }
            return locais;
        }
        public void Alterar(LocalModel local)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibLocal SET descLocal = @descricao WHERE codLocal = @codLocal");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codLocal", local.codLocal);
                    command.Parameters.Add(new SqlParameter("@descricao", local.descricao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        private LocalModel PopulateDr(SqlDataReader dr)
        {
            string codLocal = "";
            string descLocal = "";
            if (DBNull.Value != dr["codLocal"])
            {
                codLocal = dr["codLocal"] + "";
            }
            if (DBNull.Value != dr["descLocal"])
            {
                descLocal = dr["descLocal"] + "";
            }
            return new LocalModel()
            {
                codLocal = codLocal,
                descricao = descLocal,
            };
        }
    }
}
