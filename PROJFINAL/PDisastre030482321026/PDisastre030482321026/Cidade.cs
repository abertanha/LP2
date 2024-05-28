using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDisastre030482321026
{
    internal class Cidade
    {
        public int idCidade { get; set; }
        public string nome { get; set; }
        public string uf { get; set;}
        public int populacao {  get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();

            try 
            {
                daCidade = new SqlDataAdapter("SELECT * FROM Cidade ORDER BY NOME",
                    frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception)
            {
                throw;
            }
            return dtCidade;
        }
        public int Incluir() 
        {
            int retorno = 0;

            try
            {
                SqlCommand myCommand;
                myCommand = new SqlCommand("INSERT INTO Cidade VALUES (@NOME, @UF, @POPULACAO)", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@NOME", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@UF", SqlDbType.Char));
                myCommand.Parameters.Add(new SqlParameter("@POPULACAO", SqlDbType.Int));

                myCommand.Parameters["@NOME"].Value = nome;
                myCommand.Parameters["@UF"].Value = uf;
                myCommand.Parameters["@POPULACAO"].Value = populacao;
                retorno = myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        public int Alterar() 
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE Cidade SET NOME=@NOME, UF=@UF, POPULACAO=@POPULACAO WHERE IDCidade=@IDCidade", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@IDCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NOME", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@UF", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@POPULACAO", SqlDbType.Int));

                mycommand.Parameters["@IDCidade"].Value = idCidade;
                mycommand.Parameters["@NOME"].Value = nome;
                mycommand.Parameters["@UF"].Value = uf;
                mycommand.Parameters["@POPULACAO"].Value = populacao;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw; 
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM Cidade WHERE IDCidade=@IDCidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDCidade", SqlDbType.Int));
                mycommand.Parameters["@IDCidade"].Value = idCidade;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception) 
            {
            throw;
            }

            return nReg;
        }
    }
}
