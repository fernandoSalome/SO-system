using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjlink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //código principal, pré definido pelo Linq para atualizar e/ou salvar os dados do form na tabela
        private void tbClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLoginDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLoginDataSet.tbClientes' table. You can move, or remove it, as needed.
            this.tbClientesTableAdapter.Fill(this.dBLoginDataSet.tbClientes);

        }
        // ecento "digitando na caixa de texto"
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //o código abaixo faz uma pesquisa avançada com filtro usando o Link to SQL
            this.tbClientesBindingSource.Filter = "cliNome like '" + txtPesquisar.Text + "%'";
            //a linha abaixo abaixo faz a pesquisa no banco e atualiza todos os objetos do form
            this.tbClientesTableAdapter.Fill(this.dBLoginDataSet.tbClientes);
        }
        //evento adicionar um novo cliente
        private void btnNew_Click(object sender, EventArgs e)
        {
            //uso do link para fazer um insert na tabela
            this.Validate();
            this.tbClientesBindingSource.AddNew();
            btnNew.Enabled = false;
        }
        //evento para atualizar e/ou salvar 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //cópia do código principal(ícone disquete)
            this.Validate();
            this.tbClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLoginDataSet);
            //confirmação
            MessageBox.Show("Salvo com sucesso");
            btnNew.Enabled = true;
        }

        //evento para excluir um registro do banco
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //antes de tudo confirmar a exclusão
            if (MessageBox.Show("Confirma a exclusão ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //uso do link para excluir um registro
                this.tbClientesBindingSource.RemoveCurrent();
                //atualizando o banco
                this.Validate();
                this.tbClientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBLoginDataSet);
                //confirmação
                MessageBox.Show("Removido com sucesso");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //a estrutura abaixo "traz" uma imagem do computador usando o objeto opnefiledialog(explorador de arquivos do windows)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
