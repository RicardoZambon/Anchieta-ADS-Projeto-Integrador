using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014.Formularios.Empresa
{
    public class Empresa
    {
        public Empresa()
        {
        }

        #region Encapsulamento de dados da Empresa
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string inscrEstadual;
        public string InscrEstadual
        {
            get { return inscrEstadual; }
            set { inscrEstadual = value; }
        }

        private string nomeEmpresa;
        public string NomeEmpresa
        {
            get { return nomeEmpresa; }
            set { nomeEmpresa = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string tel1;
        public string Tel1
        {
            get { return tel1; }
            set { tel1 = value; }
        }

        private string tel2;
        public string Tel2
        {
            get { return tel2; }
            set { tel2 = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion
    }
    
    public class EmpresaDAL
    {
        private clsBancoDeDados BancoDeDados;
        private SqlCommand cmd;
        private DataTable Tabela;
        public DataTable Consultar()
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();


            cmd.CommandText = @"select e.Codigo, e.CNPJ, e.empresa, e.InscricaoEstadual, e.RazaoSocial, e.Endereco,
                                e.Bairro, e.EnderecoNum, e.cep, e.Email, e.Telefone1, e.Telefone2 from Empresas e";
            return Tabela = BancoDeDados.ExecutaSelect(cmd);
        }

        public DataTable ConsultarEmpresa()
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();


            cmd.CommandText = @"Select codigo, empresa From Empresas";
            return Tabela = BancoDeDados.ExecutaSelect(cmd);
        }

        public int ConsultarEmpresa(string empresa)
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();
            int result = 0;

            cmd.CommandText = @"Select codigo From Empresas where empresa = @empresa";
            cmd.Parameters.Add("empresa", SqlDbType.VarChar).Value = empresa;

            Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.Rows.Count > 0 && Tabela != null)
            {
                result = int.Parse(Tabela.Rows[0]["codigo"].ToString());
            }

            return result;
        }

        public DataTable Consultar(Empresa emp)
        {
            this.BancoDeDados = new clsBancoDeDados();
            this.cmd = new SqlCommand();
            this.Tabela = new DataTable();


            cmd.CommandText = @"Select * From Empresas 
                                    where codigo like @codigo 
                                    and cnpj like @cnpj 
                                    and empresa like @empresa";
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = emp.Codigo + "%";
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = emp.Cnpj + "%";
            cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = emp.NomeEmpresa + "%";
            return Tabela.DataSet.Tables[0].Rows.Count > 0 ? BancoDeDados.ExecutaSelect(cmd) : null;
        }

        public void Excluir(int codigo)
        {
            this.cmd = new SqlCommand();
            this.BancoDeDados = new clsBancoDeDados();

            cmd.CommandText = @"delete from Empresas where codigo = @codigo";
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
            BancoDeDados.ExecutaCommand(cmd);
        }

        public void Gravar(Empresa emp)
        {
            this.cmd = new SqlCommand();
            this.BancoDeDados = new clsBancoDeDados();

            if (emp.Codigo == 0)
            {
                cmd.CommandText = @"insert into Empresas(cnpj, empresa, InscricaoEstadual, endereco, EnderecoNum, bairro, cep, telefone1, telefone2, email) 
                                    values(@cnpj, @empresa, @inscr, @endereco, @numero, @bairro, @cep, @tel1, @tel2, @email)";
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = emp.Cnpj;
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = emp.NomeEmpresa;
                cmd.Parameters.Add("@inscr", SqlDbType.VarChar).Value = emp.InscrEstadual;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = emp.Endereco;
                cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = emp.Numero;
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = emp.Bairro;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = emp.Cep;
                cmd.Parameters.Add("@tel1", SqlDbType.VarChar).Value = emp.Tel1;
                cmd.Parameters.Add("@tel2", SqlDbType.VarChar).Value = emp.Tel2;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emp.Email;
            }
            else
            {
                cmd.CommandText = @"update Empresas 
                                        set cnpj = @cnpj, 
                                        empresa = @empresa, 
                                        InscricaoEstadual = @inscr,
                                        endereco = @endereco, 
                                        enderecoNum = @numero,
                                        bairro = @bairro,
                                        cep = @cep,
                                        telefone1 = @tel1,
                                        telefone2 = @tel2,
                                        email = @email
                                        where codigo = @codigo";
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = emp.Cnpj;
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = emp.NomeEmpresa;
                cmd.Parameters.Add("@inscr", SqlDbType.VarChar).Value = emp.InscrEstadual;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = emp.Endereco;
                cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = emp.Numero;
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = emp.Bairro;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = emp.Cep;
                cmd.Parameters.Add("@tel1", SqlDbType.VarChar).Value = emp.Tel1;
                cmd.Parameters.Add("@tel2", SqlDbType.VarChar).Value = emp.Tel2;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emp.Email;
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = emp.Codigo;
            }
            BancoDeDados.ExecutaCommand(cmd);
        }
    }
}
