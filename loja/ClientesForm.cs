using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace Loja
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ClientesBLL obj = new ClientesBLL();
            clientesDataGridView.DataSource = obj.Listagem();

            // Atualizando os objetos TextBox
            codigoTextBox.Text = clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString();
            emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString();
            telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString();
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }
    }
}
