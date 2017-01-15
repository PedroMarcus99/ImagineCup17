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
using AppSharingVehicle.Resources.Conexao.MODEL;
using AppSharingVehicle.Resources.Conexao.DTO;
using System.Data; 


namespace AppSharingVehicle.Resources.Conexao.CONTROL
{
    public class Control
    {
        Model bd;

        /// <summary>
        /// Método que insere um usuário ao sistema e o cadastra para realizar Login no sistema
        /// </summary>
        /// <param DTOUsuario="dto"></param>
        public void inserir(DTOUsuario dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new Model();
                bd.Conectar();
                string comando = "INSERT INTO Usuario (Nome, Senha) values ('" + nome + "','" + dto.Senha + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar o usuário: /n" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }


        //public DataTable SelecionaTodosLivros()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {

        //        bd = new Model();
        //        bd.Conectar();
        //        dt = bd.RetDataTable("Select * from dados");

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao tentar cadastrar o livro:" + ex.Message);
        //    }
        //    finally
        //    {
        //        bd = null;
        //    }
        //    return dt;
        //}

        /// <summary>
        /// Este Método atualiza as informações dos usuários. 
        /// </summary>
        /// <param name="dto"></param>
        public void atualizar(DTOUsuario dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new Model();
                bd.Conectar();
                string comando = "UPDATE dados set Nome = '" + dto.Nome + "', Senha = '" + dto.Senha + "'where idUsuario = " + dto.Id;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar o cliente:" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        public void excluir(DTOUsuario dto)
        {
            try
            {
                bd = new Model();
                bd.Conectar();
                string comando = "DELETE FROM dados where idUsuario =" + dto.Id;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o livro:" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
    }
}