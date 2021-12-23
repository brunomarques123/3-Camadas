using System;
using System.Windows.Forms;
using Servico;
using Modelo;


namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {
        DisciplinaServico disciplinaServico = new DisciplinaServico();  // precisei estanciar aqui 1

        public DisciplinaForm()
        {
            InitializeComponent();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if(txtCargaHoraria.Text == "")
            {
                MessageBox.Show("Carga Horaria nao informada");
                return;
            }
            disciplinaServico.Inserir(new Disciplina()
            {
                Nome = txtNome.Text,
                CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text)

            });

            AtualizarDataGridView();
            MessageBox.Show("Inserção realizada com Sucesso");
        }
        private void AtualizarDataGridView()
        {
            dgvDisciplinas.DataSource = null;
            dgvDisciplinas.DataSource = disciplinaServico.ObterTodas();
        }
    }
}
