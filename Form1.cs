using System;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        private VeiculoBLL bll = new VeiculoBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1 carregado com sucesso em 2026.");
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvVeiculos.DataSource = bll.BuscarTodosOsVeiculos();
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoModel veiculo = new VeiculoModel
                {
                    Modelo = textBox2.Text,
                    Marca = textBox3.Text,
                    Ano = int.Parse(textBox4.Text),
                    Placa = textBox5.Text,
                    Dono = textBox6.Text
                };

                bll.SalvarVeiculo(veiculo);
                MessageBox.Show("Veículo cadastrado com sucesso!");
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoModel veiculo = new VeiculoModel
                {
                    IdVeiculo = int.Parse(textBox1.Text),
                    Modelo = textBox2.Text,
                    Marca = textBox3.Text,
                    Ano = int.Parse(textBox4.Text),
                    Placa = textBox5.Text,
                    Dono = textBox6.Text
                };

                bll.EditarVeiculo(veiculo);
                MessageBox.Show("Veículo atualizado com sucesso!");
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                bll.DeletarVeiculo(id);
                MessageBox.Show("Veículo excluído com sucesso!");
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvVeiculos.Rows[e.RowIndex];

                textBox1.Text = linha.Cells["id_veiculo"].Value.ToString();
                textBox2.Text = linha.Cells["Modelo"].Value.ToString();
                textBox3.Text = linha.Cells["Marca"].Value.ToString();
                textBox4.Text = linha.Cells["Ano"].Value.ToString();
                textBox5.Text = linha.Cells["Placa"].Value.ToString();
                textBox6.Text = linha.Cells["Dono"].Value.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void dgvVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}