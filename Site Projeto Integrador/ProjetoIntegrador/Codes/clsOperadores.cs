using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador {
    public class clsOperadores {
        private int iCodigo;
        public int ICodigo {
            get { return iCodigo; }
            set { iCodigo = value; }
        }

        private string sNome;
        public string SNome {
            get { return sNome; }
            set { sNome = value; }
        }

        private string sUsuario;
        public string SUsuario {
            get { return sUsuario; }
            set { sUsuario = value; }
        }

        private string sSenha;
        public string SSenha {
            get { return sSenha; }
            set { sSenha = value; }
        }

        public static string NomeLogin;
    }

    class clsOperadoresDAL {
        public DataTable Carregar() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Codigo,CpfCnpj,NomeCompleto,Usuario,CEP,Oculto,Ativo,Excluido From Operadores";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public clsOperadores Carregar(int Codigo) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Codigo,Nome,Usuario From Usuarios Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0) {
                clsOperadores Operador = new clsOperadores();
                Operador.ICodigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Operador.SNome = Tabela.Rows[0]["Nome"].ToString();
                Operador.SUsuario = Tabela.Rows[0]["Usuario"].ToString();
                return Operador;
            } else
                return null;
        }

        public clsOperadores Carregar(string Usuario) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Codigo,Nome,Usuario From Usuarios Where Usuario Like @Usuario";
            cmd.Parameters.Add("Usuario", SqlDbType.VarChar).Value = Usuario;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0) {
                clsOperadores Operador = new clsOperadores();
                Operador.ICodigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Operador.SNome = Tabela.Rows[0]["Nome"].ToString();
                Operador.SUsuario = Tabela.Rows[0]["Usuario"].ToString();
                return Operador;
            } else
                return null;
        }

        public bool EfetuaLogin(clsOperadores Operador) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Usuario From Usuarios Where Usuario=@Usuario And Senha=@Senha ";
            cmd.Parameters.Add("Usuario", SqlDbType.VarChar).Value = Operador.SUsuario;
            cmd.Parameters.Add("Senha", SqlDbType.VarChar).Value = Operador.SSenha;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}