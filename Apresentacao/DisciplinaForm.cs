using System;
using System.Windows.Forms;
using Servico;
using Modelo;
using System.Configuration;
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {

        DisciplinaServico disciplinaServico;
        string connetionString = 
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\welli\\Desktop\\Pastas sobre C#\\LivroC#\\Projeto\\Modelo\\Persistencia\\App_Data\\ADO_NETDataBase.mdf';Integrated Security=True;";

        Disciplina disciplinaAtual = new Disciplina();

        //DisciplinaServico disciplinaServico = new DisciplinaServico(connection);  // precisei estanciar aqui 1

        public DisciplinaForm()
        {
            InitializeComponent();
            disciplinaServico = new DisciplinaServico(new SqlConnection(connetionString));
            AtualizarDataGridView();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (txtCargaHoraria.Text == "")
            {
                MessageBox.Show("Carga Horaria nao informada");
                return;
            }
            disciplinaAtual.Nome = txtNome.Text;
            disciplinaAtual.CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text);
            disciplinaServico.Gravar(disciplinaAtual);
            AtualizarDataGridView();
            MessageBox.Show("Gravação realizada como sucesso");          
        }

        private void AtualizarDataGridView()
        {
            dgvDisciplinas.DataSource = null;
            dgvDisciplinas.DataSource = disciplinaServico.ObterTodas();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            disciplinaAtual = disciplinaServico.ObterPorId(Convert.ToInt32(txtIDPesquisar.Text));
            if (disciplinaAtual.DisciplinaId == null)
            {
                MessageBox.Show("Disciplina não encontrada");
            }
            else
            {
                txtNome.Text = disciplinaAtual.Nome;
                txtCargaHoraria.Text = disciplinaAtual.CargaHoraria.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(disciplinaAtual.DisciplinaId == null)
            {
                MessageBox.Show("Pesquise por uma diciplina antes");
            }
            else
            {
                disciplinaServico.Remover(disciplinaAtual);
                MessageBox.Show("Disciplina Removida");
                AtualizarDataGridView();

            }
        }
    }
}
