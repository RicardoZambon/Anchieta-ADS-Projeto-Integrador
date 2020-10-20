using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoIntegrador2014.Formularios.Usuario
{
    public class Usuario
    {
        #region Encapsulamento dos dados do Usuario
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nomeCompleto;
        public string NomeCompleto
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
        }

        private string nomeAcesso;
        public string NomeAcesso
        {
            get { return nomeAcesso; }
            set { nomeAcesso = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private int nivel;
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        private int empresa;
        public int Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        private int departamento;
        public int Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        #endregion
    }

    public class UsuarioDAL
    {
        private clsBancoDeDados BancoDeDados;
        private SqlCommand cmd;
        private DataTable Tabela;
        public DataTable Consultar()
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();


            cmd.CommandText = @"select u.codigo, u.Nome, u.Usuario, u.Senha, ut.Tipo, dep.Departamento, 
                                emp.empresa from Usuarios u, Empresas emp, Departamentos dep, Usuarios_Tipos ut
                                where u.Departamento = dep.Codigo and u.Empresa = emp.Codigo and u.Tipo = ut.Codigo";
            return Tabela = BancoDeDados.ExecutaSelect(cmd);
        }

        public DataTable ConsultarCodigo(Usuario user)
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();

            cmd.CommandText = @"Select * From Usuarios 
                                    where usuario = @nomeacesso ";
            
            cmd.Parameters.Add("@nomeacesso", SqlDbType.VarChar).Value = user.NomeAcesso;
            Tabela = BancoDeDados.ExecutaSelect(cmd);
            return Tabela.DataSet.Tables[0].Rows.Count > 0 ? BancoDeDados.ExecutaSelect(cmd) : null;
        }
        
        public DataTable Consultar(Usuario user)
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();

            cmd.CommandText = @"Select * From Usuarios 
                                    where nome like @nomeComp
                                    and usuario like @nomeacesso
                                    and empresa like @empresa
                                    and departamento like @dept";
          
            cmd.Parameters.Add("@nomeComp", SqlDbType.VarChar).Value = user.NomeCompleto + "%";
            cmd.Parameters.Add("@nomeacesso", SqlDbType.VarChar).Value = user.NomeAcesso + "%";
            cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = user.Empresa + "%";
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = user.Departamento + "%";
            Tabela = BancoDeDados.ExecutaSelect(cmd);
            return Tabela.DataSet.Tables[0].Rows.Count > 0 ? BancoDeDados.ExecutaSelect(cmd) : null;
        }

        public void Excluir(int codigo)
        {
            this.cmd = new SqlCommand();
            this.BancoDeDados = new clsBancoDeDados();

            cmd.CommandText = @"delete from Usuarios where codigo = @codigo";
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
            BancoDeDados.ExecutaCommand(cmd);
        }

        public DataTable BuscarNivel()
        {
            this.cmd = new SqlCommand();
            this.BancoDeDados = new clsBancoDeDados();

            cmd.CommandText = @" select * from Usuarios_Tipos ";
             return BancoDeDados.ExecutaSelect(cmd);
        }

        public void Gravar(Usuario user)
        {
            this.cmd = new SqlCommand();
            this.BancoDeDados = new clsBancoDeDados();

            if (user.Codigo == 0)
            {
                cmd.CommandText = @"insert into Usuarios(nome, usuario, senha, tipo, empresa, departamento) 
                                    values(@nomecomp, @nomeacesso, @senha, @nivel, @empresa, @dept)";
                cmd.Parameters.Add("@nomecomp", SqlDbType.VarChar).Value = user.NomeCompleto;
                cmd.Parameters.Add("@nomeacesso", SqlDbType.VarChar).Value = user.NomeAcesso;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = user.Senha;
                cmd.Parameters.Add("@nivel", SqlDbType.VarChar).Value = user.Nivel;
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = user.Empresa;
                cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = user.Departamento;
            }
            else
            {
                cmd.CommandText = @"update Usuarios 
                                        set nome = @nomecomp, 
                                        usuario = @nomeacesso, 
                                        senha = @senha,
                                        tipo = @nivel, 
                                        empresa = @empresa,
                                        departamento = @dept
                                        where codigo = @codigo";
                cmd.Parameters.Add("@nomecomp", SqlDbType.VarChar).Value = user.NomeCompleto;
                cmd.Parameters.Add("@nomeacesso", SqlDbType.VarChar).Value = user.NomeAcesso;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = user.Senha;
                cmd.Parameters.Add("@nivel", SqlDbType.VarChar).Value = user.Nivel;
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = user.Empresa;
                cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = user.Departamento;
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = user.Codigo;
            }
            BancoDeDados.ExecutaCommand(cmd);
        }
    }
}
