using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014.Formularios.Departamento
{
    class Departamentos
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        private int empresa;
        public int Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        private string responsavel;
        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }
    }

    class DepartamentosDAL
    {
        public DataTable Consultar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select d.codigo, d.departamento, d.responsavel, d.empresa codEmpresa,
                                e.empresa from Departamentos d, Empresas e
                                where d.Empresa = e.Codigo";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public DataTable ConsultarDept()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select codigo, departamento From Departamentos";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public Departamentos Consultar(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select d.codigo, d.departamento, d.responsavel, d.empresa codEmpresa,
                                e.empresa from Departamentos d, Empresas e
                                where d.Empresa = e.Codigo and d.Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                Departamentos Departamento = new Departamentos();
                Departamento.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Departamento.Departamento = Tabela.Rows[0]["Departamento"].ToString();
                Departamento.Empresa = int.Parse(Tabela.Rows[0]["Empresa"].ToString());
                Departamento.Responsavel = Tabela.Rows[0]["Responsavel"].ToString();
                return Departamento;
            }
            else
                return null;
        }

        public DataTable ConsultarDept(Departamentos dept)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Departamentos Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = dept.Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela != null && Tabela.Rows.Count > 0)
            {
                return Tabela;
            }
            else
                return null;
        }

        public void Excluir(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete Departamentos Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }

        public void Gravar(Departamentos Departamento)
        {
            SqlCommand cmd = new SqlCommand();
            if (Departamento.Codigo == 0)
            {
                cmd.CommandText = "Insert Into Departamentos (Departamento,Empresa,Responsavel) Values(@Departamento,@Empresa, @Responsavel)";
                cmd.Parameters.Add("Departamento", SqlDbType.VarChar).Value = Departamento.Departamento;
                cmd.Parameters.Add("Empresa", SqlDbType.Int).Value = Departamento.Empresa;
                cmd.Parameters.Add("Responsavel", SqlDbType.VarChar).Value = Departamento.Responsavel;
            }
            else
            {
                cmd.CommandText = "Update Departamentos Set Departamento=@Departamento, Empresa=@Empresa, Responsavel=@Responsavel Where Codigo=@Codigo";
                cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Departamento.Codigo;
                cmd.Parameters.Add("Departamento", SqlDbType.VarChar).Value = Departamento.Departamento;
                cmd.Parameters.Add("Empresa", SqlDbType.Int).Value = Departamento.Empresa;
                cmd.Parameters.Add("Responsavel", SqlDbType.VarChar).Value = Departamento.Responsavel;
            }
            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }
    }
}
