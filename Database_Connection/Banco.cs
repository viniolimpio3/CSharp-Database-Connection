using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Database_Connection
{
    class Banco
    {
        //Maneiras de Conectar com o banco:
        //string conexao = "Server=localhost; user id = {USER}; database={DATABASE}; SslMode=none  ";
        // --- OU ---
        //string conexao = Properties.Settings.Default.ConexaoMysql;

        string connection = Properties.Settings.Default.ConexaoMysql;//OBS:seta "ConexaoMysql" Em Settings.Settings

        //objetos de conexão
        MySqlConnection objCon = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        private MySqlConnection openDatabase(){
            
            objCon.ConnectionString = this.connection;
            objCon.Open();

            return objCon;
        }

        private void closeDatabase(MySqlConnection c){
            if(c.State == ConnectionState.Open){
                c.Close();
            }
        } 

        //MÉTODOS PUBLIC - (que não são de conexão)

        //Retorna o DataSet
        public MySqlDataReader dataSet(string query){
            try{
                //se banco não estiver aberto
                
                    objCon = openDatabase();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = objCon;
                

                return cmd.ExecuteReader();

            }
            catch(Exception e){
                throw e;
            }
        }
        //Executa o comando
        public void comando(string query){
            try{

                objCon = openDatabase();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = objCon;
                cmd.ExecuteNonQuery();

            }catch(Exception e){
                throw e;
            }
        }

        //PESQUISAR
        public MySqlDataReader search( int cod ){

            StringBuilder query = new StringBuilder();
            query.Append("select * from tabprod where CodProd=" + cod);
            return dataSet(query.ToString()); 

        }


    }
}
