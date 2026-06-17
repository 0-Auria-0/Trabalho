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

        dal.InserirVeiculoNoBanco(veiculo);
    }

    public void EditarVeiculo(VeiculoModel veiculo)
    {
        if (veiculo.IdVeiculo <= 0)
        {
            throw new Exception("ID inválido para alteração!");
        }

        dal.AlterarVeiculoNoBanco(veiculo);
    }

    public void DeletarVeiculo(int id)
    {
        if (id <= 0)
        {
            throw new Exception("ID inválido para exclusão!");
        }

        dal.ExcluirVeiculoNoBanco(id);
    }

    public DataTable BuscarTodosOsVeiculos()
    {
        return dal.ListarTodosOsVeiculos();
    }
}