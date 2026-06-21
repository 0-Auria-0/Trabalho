using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Trabalho;

public class VeiculoDAL
{
    private string linhaConexao = "Server=localhost;Database=ControleVeiculos;Uid=root;Pwd=suzana123;";

    public void InserirVeiculoNoBanco(VeiculoModel veiculo)
    {
        MySqlConnection conexao = new MySqlConnection(linhaConexao);
        MySqlCommand comando = new MySqlCommand("sp_InsertVeiculo", conexao);
        comando.CommandType = CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@p_modelo", veiculo.Modelo);
        comando.Parameters.AddWithValue("@p_marca", veiculo.Marca);
        comando.Parameters.AddWithValue("@p_ano", veiculo.Ano);
        comando.Parameters.AddWithValue("@p_placa", veiculo.Placa);
        comando.Parameters.AddWithValue("@p_dono", veiculo.Dono);

        conexao.Open();
        comando.ExecuteNonQuery();
        conexao.Close();
    }

    public void AlterarVeiculoNoBanco(VeiculoModel veiculo)
    {
        MySqlConnection conexao = new MySqlConnection(linhaConexao);
        MySqlCommand comando = new MySqlCommand("sp_UpdateVeiculo", conexao);
        comando.CommandType = CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@p_id", veiculo.IdVeiculo);
        comando.Parameters.AddWithValue("@p_modelo", veiculo.Modelo);
        comando.Parameters.AddWithValue("@p_marca", veiculo.Marca);
        comando.Parameters.AddWithValue("@p_ano", veiculo.Ano);
        comando.Parameters.AddWithValue("@p_placa", veiculo.Placa);
        comando.Parameters.AddWithValue("@p_dono", veiculo.Dono);

        conexao.Open();
        comando.ExecuteNonQuery();
        conexao.Close();
    }

    public void ExcluirVeiculoNoBanco(int id)
    {
        MySqlConnection conexao = new MySqlConnection(linhaConexao);
        MySqlCommand comando = new MySqlCommand("sp_DeleteVeiculo", conexao);
        comando.CommandType = CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("p_id", id);

        conexao.Open();
        comando.ExecuteNonQuery();
        conexao.Close();
    }

    public DataTable ListarTodosOsVeiculos()
    {
        MySqlConnection conexao = new MySqlConnection(linhaConexao);
        MySqlCommand comando = new MySqlCommand("sp_SelectVeiculos", conexao);
        comando.CommandType = CommandType.StoredProcedure;

        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
        DataTable tabelaDados = new DataTable();

        conexao.Open();
        adaptador.Fill(tabelaDados);
        conexao.Close();

        return tabelaDados;
    }
}