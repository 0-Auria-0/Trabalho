using System;
using System.Data;
using Trabalho;

public class VeiculoBLL
{
    private VeiculoDAL dal = new VeiculoDAL();

    public void SalvarVeiculo(VeiculoModel veiculo)
    {
        if (string.IsNullOrEmpty(veiculo.Placa))
        {
            throw new Exception("A placa do veículo é obrigatória!");
        }
        if (string.IsNullOrEmpty(veiculo.Modelo))
        {
            throw new Exception("O modelo do veículo é obrigatório!");
        }

        dal.InserirVeiculoNoBanco(veiculo);
    }

    public void EditarVeiculo(VeiculoModel veiculo)
    {
        if (veiculo.IdVeiculo <= 0)
        {
            throw new Exception("Selecione um veículo na tabela antes de editar!");
        }

        dal.AlterarVeiculoNoBanco(veiculo);
    }

    public void DeletarVeiculo(int id)
    {
        if (id <= 0)
        {
            throw new Exception("Selecione um veículo na tabela antes de excluir!");
        }

        dal.ExcluirVeiculoNoBanco(id);
    }

    public DataTable BuscarTodosOsVeiculos()
    {
        return dal.ListarTodosOsVeiculos();
    }
}