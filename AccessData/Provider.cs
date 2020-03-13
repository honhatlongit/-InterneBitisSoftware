using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public class Provider
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private DataSet dts;
        private DataTable tbl;
        private SqlDataReader dataReader;
        private SqlDataAdapter dataAdapter;

        public Provider(string connectionString)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;
        }

        public bool ExecuteNonQuery(string procedure, SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure, CommandText = procedure, Connection = cnn };
                if (parameters != null) //Trường hợp có tham số
                {
                    cmd.Parameters.Clear();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i]);
                    }
                }
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (cnn.State != ConnectionState.Closed) { cnn.Close(); }
                //cnn.Dispose();
                cmd.Dispose();
            }
        }

        public DataTable ExecuteQuery(string procedure, SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure, CommandText = procedure, Connection = cnn };
                if (parameters != null) //Trường hợp có tham số
                {
                    cmd.Parameters.Clear();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i]);
                    }
                }
                dataAdapter = new SqlDataAdapter(cmd);
                tbl = new DataTable(procedure);
                dataAdapter.Fill(tbl);
                cnn.Close();
                return tbl;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State != ConnectionState.Closed) { cnn.Close(); }
                //cnn.Dispose();
                cmd.Dispose();
                dataAdapter.Dispose();
            }
        }

        public bool ImportExcelToDb(string procdure, SqlParameter[,] parameters)
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlTransaction transaction;
            transaction = cnn.BeginTransaction(); //, Transaction = transaction
            try
            {
                cmd = new SqlCommand() { CommandType = CommandType.StoredProcedure, CommandText = procdure, Connection = cnn, Transaction = transaction };
                if (parameters != null)
                {
                    long x = parameters.GetLength(0);
                    long y = parameters.GetLength(1);
                    for (int i = 0; i < x; i++)
                    {
                        cmd.Parameters.Clear();
                        for (int j = 0; j < y; j++)
                        {
                            cmd.Parameters.Add(parameters[i, j]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
