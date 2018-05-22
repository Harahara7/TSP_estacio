using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;
using System.Configuration;

namespace ERYTEC.GEXP.Model
{
    public class Model
    {
        #region Objetos

        public MySqlCommand dataCommand = new MySqlCommand();
        private string retorno = string.Empty;

        #endregion

        #region Métodos

        public Model()
        {
            MySqlConnection dataConnection = new MySqlConnection();
            dataConnection.ConnectionString = ConfigurationManager.ConnectionStrings["dbestacio"].ToString();

            dataCommand.Connection = dataConnection;
            dataCommand.CommandType = CommandType.Text;
        }

        public Int32 ExecutaComando(string commandtext)
        {
            try
            {
                Int32 retorno = 0;
                dataCommand.CommandText = commandtext;
                Open();
                //Esse método retorna um inteiro, referente a quantidade de linhas inseridas.
                dataCommand.ExecuteNonQuery();
                Close();

                //retorno = "Sucesso!!!";
                Console.WriteLine("Sucesso!");
                return retorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //retorno = ex.Message;
                return 0;
            }

        }

        public int ExecutarComando(string commandtext)
        {
            try
            {
                dataCommand.CommandText = commandtext;
                Open();
                //Esse método retorna um inteiro, referente a quantidade de linhas inseridas.
                int i = dataCommand.ExecuteNonQuery();
                Close();
                return i;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }

        public DataSet ExecuteDataSet(string commandtext)
        {
            DataSet Ds = null;
            try
            {
                dataCommand.CommandText = commandtext;
                dataCommand.CommandTimeout = 350;
                MySqlDataAdapter Da = new MySqlDataAdapter(dataCommand);
                Ds = new DataSet();
                Da.Fill(Ds, "Consulta");
                return Ds;

            }
            catch (Exception ex)
            {
                return Ds;
            }
            finally
            {
                Close();
            }
        }

        public DataTable ExecuteDataTable(string commandtext)
        {          

            DataTable dt = null;
            try
            {
                dataCommand.CommandText = commandtext;

                MySqlDataAdapter Da = new MySqlDataAdapter(dataCommand);
                dt = new DataTable();
                Da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                return dt;
                //throw;
            }
            finally
            {
                Close();
            }
        }

        public string ExecutaScalar(string commandtext)
        {
            try
            {
                string Retorno = string.Empty;
                Open();
                dataCommand.CommandText = commandtext;
                dataCommand.CommandTimeout = 230;
                Retorno = Convert.ToString(dataCommand.ExecuteScalar());

                return Retorno;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Close();
            }
        }

        public void AddParameter(string paramname, object paramvalue)
        {

            MySqlParameter param = new MySqlParameter(paramname, paramvalue);
            dataCommand.Parameters.Add(param);

        }

        public void Clear()
        {
            dataCommand.Parameters.Clear();
        }

        private void Open()
        {
            dataCommand.Connection.Open();
        }

        private void Close()
        {
            dataCommand.Connection.Close();
        }

        public void Dispose()
        {
            dataCommand.Dispose();
        }

        #endregion
    }
}
