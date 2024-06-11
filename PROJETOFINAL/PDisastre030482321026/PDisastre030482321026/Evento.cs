using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PDisastre030482321026
{
    internal class Evento
    {
        public int IdEvento{ get; set; }
        public int Tipo_IdTipo { get;set; }
        public int Cidade_IdCidade { get;set; }
        public char NivelSeveridade { get; set; } 
        public int AreaAfetada { get;set; }
        public int PessoasAfetadas { get;set; }
        public string Observacao { get;set; }   
        public DateTime DataOcorrencia { get;set; }

        public DataTable Listar() 
        {
            SqlDataAdapter daEvento;
            DataTable dtEvento = new DataTable();

            try 
            {
                daEvento = new SqlDataAdapter("SELECT * FROM Evento ORDER BY IDEVENTO", frmPrincipal.conexao);
                daEvento.Fill(dtEvento);
                daEvento.FillSchema(dtEvento, SchemaType.Source);
            }
            catch (Exception ) 
            {
                throw;
            }
            return dtEvento;
        }
        public int Incluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO Tipo VALUES (@IDTIPO,@IDCIDADE,@NIVELSEVERIDADE,@AREAAFETADA,@PESSOASAFETADAS,@OBSERVACAO,@DATAOCORRENCIA)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@IDTIPO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDCIDADE", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NIVELSEVERIDADE", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@AREAAFETADA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@PESSOASAFETADAS", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@OBSERVACAO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@DATAOCORRENCIA", SqlDbType.DateTime));

                mycommand.Parameters["@IDTIPO"].Value = Tipo_IdTipo;
                mycommand.Parameters["@IDCIDADE"].Value = Cidade_IdCidade;
                mycommand.Parameters["@NIVELSEVERIDADE"].Value = NivelSeveridade;
                mycommand.Parameters["@AREAAFETADA"].Value = AreaAfetada;
                mycommand.Parameters["@PESSOASAFETADAS"].Value = PessoasAfetadas;
                mycommand.Parameters["@OBSERVACAO"].Value = Observacao;
                mycommand.Parameters["@DATAOCORRENCIA"].Value = DataOcorrencia;

                retorno = mycommand.ExecuteNonQuery();
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

                mycommand = new SqlCommand("UPDATE Evento SET " +
                    "TIPO_IDTIPO=@IDTIPO, CIDADE_IDCIDADE=@IDCIDADE, NIVELSEVERIDADE=@NIVELSEVERIDADE, " +
                    "AREAAFETADA=@AREAAFETADA, PESSOASAFETADAS=@PESSOASAFETADAS," +
                    "OBSERVACAO=@OBSERVACAO, DATAOCORRENCIA=@DATAOCORRENCIA WHERE IDEVENTO=@IDEVENTO", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDEVENTO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDTIPO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDCIDADE", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NIVELSEVERIDADE", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@AREAAFETADA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@PESSOASAFETADAS", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@OBSERVACAO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@DATAOCORRENCIA", SqlDbType.DateTime));

                mycommand.Parameters["@IDEVENTO"].Value = IdEvento;
                mycommand.Parameters["@IDTIPO"].Value = Tipo_IdTipo;
                mycommand.Parameters["@IDCIDADE"].Value = Cidade_IdCidade;
                mycommand.Parameters["@NIVELSEVERIDADE"].Value = NivelSeveridade;
                mycommand.Parameters["@AREAAFETADA"].Value = AreaAfetada;
                mycommand.Parameters["@PESSOASAFETADAS"].Value = PessoasAfetadas;
                mycommand.Parameters["@OBSERVACAO"].Value = Observacao;
                mycommand.Parameters["@DATAOCORRENCIA"].Value = DataOcorrencia;

                
                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
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

                mycommand = new SqlCommand("DELETE FROM Evento WHERE IDEvento=@IDEvento", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDEvento", SqlDbType.Int));
                mycommand.Parameters["@IDEvento"].Value = IdEvento;

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
