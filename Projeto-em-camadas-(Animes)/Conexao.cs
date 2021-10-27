using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_em_camadas__Animes_
{
    class Conexao
    {
        //passo 1
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                
                string dados_conexao = "Persist Security Info=false; " +
                                       "server=localhost; " +
                                       "database=projeto_em_camadas(animes); " +
                                       "uid=root; pwd=";
                
                conexao = new MySqlConnection(dados_conexao);
                
                conexao.Open();
            }
            catch (MySqlException erro)
            {               
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + erro.Message);
            }

        }

        public DataTable ExecutarConsulta(string sql)      
        {
            try
            {
                Conectar();               
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);                
                DataTable dt = new DataTable();               
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException erro)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)  
        {
            
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);     
                comando.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new Exception("A instrução não foi realizada.\n" + erro.Message);
            }
            finally
            {  
                conexao.Close(); 
            }
        }
    }
}
