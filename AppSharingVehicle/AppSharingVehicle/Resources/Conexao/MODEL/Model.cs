using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;
using System.Data;
using AppSharingVehicle.Resources.ClassesDeTransicao;  

namespace AppSharingVehicle.Resources.Conexao.MODEL
{
    public class Model
    {
        //Conjunto de Atributos da Classe

        //Atributo para guardar a conex�o com o banco de dados
        private MySqlConnection conn;

        //Atributo para guardar uma tabela de dados
        private DataTable data;

        //Atributo para auxiliar a convers�o de dados no formato adaptado ao formato gen�rico de dados do ADO.net que � o DataTable
        private MySqlDataAdapter da;

        //Atributos para a conex�o com o Banco de Dados
        private String server = "localhost"; //Servidor, pode ser tanto a sua m�quina local quanto um servidor de verdade
        private String user = "root"; //Usu�rio do banco de dados
        private String password = ""; //Senha do usu�rio para acessar o banco de dados
        private String database = ""; //Banco de Dados


        //Opera��es da Camada de Dados

        //Procedimento para estabelecer a conex�o com o Banco de Dados
        public void Conectar()
        {
            /*Verifica se o objeto conex�o "conn" est� em mem�ria. Caso positivo, efetua-se o fechamento da conex�o 
            com o banco de dados, pois toda opera��o executa a conex�o e n�o � permitido abrir uma conex�o que j� est� aberta.
             */
            if (conn != null)
                conn.Close();

            //Cria a vari�vel "connStr" com a String de Conex�o (informa��es necess�rias para que o MySQL consiga estabeler uma conex�o com algum banco de dados
            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);

            //Tratamento de Exce��o padr�o para tentar estabelecer a conex�o com o banco
            try
            {
                //Concretiza a cria��o do objeto "conn". Observe o uso da palavrinha "new".
                //Observe a passagem do par�metro "connStr" para o construtor da classe "MySqlConnection"
                conn = new MySqlConnection(connStr);
                conn.Open(); //Invoca o m�todo "Open()" da classe "MySqlConnection"
            }
            catch (MySqlException ex) //Se chegar aqui � porque a conex�o n�o p�de ser estabelecida e uma exce��o do tipo MySqlException ser� exibida
            {
                throw new Exception(ex.Message);
            }
        }

        //Procedimento para executar um comando SQL no Banco de Dados
        //Os comandos permitidos s�o: INSERT, UPDATE e DELETE 
        public void ExecutarComandoSQL(string comandoSql)
        {
            //Concretiza a cria��o do objeto "comando"
            //Observe a passagem de dois par�metros para o construtor da classe "MySqlCommand".
            //O primeiro par�metro representa o comando a ser executado, j� o segundo representa a conex�o pela qual o comando vai passar
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery(); //Chama o m�todo "ExecuteNonQuery()" da classe "MySqlCommand" para execu��o do comando
            conn.Close(); //Garante o fechamento da conex�o com o banco de dados
        }

        //Fun��o respons�vel pelo retorno de um objeto "DataTable" (tabela de dados) dado que um comando SQL � passado como par�metro
        //NOTA: Aqui s� pode chegar comando do tipo SELECT
        public DataTable RetDataTable(string sql)
        {
            //Como a fun��o retorna um objeto DataTable, precisamos garantir um objeto que ser� retornado.
            //Concretiza-se a cria��o do objeto "data" do tipo DataTable
            data = new DataTable();

            //Concretiza a cria��o do objeto "da". Observe que os par�metros "sql" e "conn" s�o passados para o construtor da classe "MySqlDataAdapter"
            da = new MySqlDataAdapter(sql, conn);

            //Preenche o objeto "data" com os dados que est�o no objeto "da"
            da.Fill(data);

            //Retorna o objeto "data" j� preenchido
            return data;
        }

        //Fun��o respons�vel pelo retorno do objeto MySqlDataReader dado que um comando "SELECT" � enviado
        public MySqlDataReader RetDataReader(string sql)
        {
            //Concretiza a cria��o do objeto "comando" 
            //Observe que os par�metros "sql" e "conn" s�o passados para o construtor da classe "MySqlCommand"
            MySqlCommand comando = new MySqlCommand(sql, conn);

            //Agora que o objeto "comando" est� criado, basta execut�-lo de modo que ele retorno um objeto do tipo "MySqlDataReader" 
            //Observe a cria��o e ao mesmo tempo a atribui��o de valor para o objeto dr
            MySqlDataReader dr = comando.ExecuteReader();

            //O objeto precisa ser lido para liberar seu uso
            dr.Read();

            //Retorno do objeto "dr" j� preenchido
            return dr;
        }
    }
}