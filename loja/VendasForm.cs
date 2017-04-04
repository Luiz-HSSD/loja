using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelos;
namespace Loja
{
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }
        private void VendasForm_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            clienteComboBox.DataSource = obj.ListaDeClientes;
            produtoComboBox.DataSource = obj.ListaDeProdutos;
        }
        private void incluirVendaButton_Click(object sender, EventArgs e)
        {
            try
            {
                VendaInformation venda = new VendaInformation();
                venda.Quantidade = int.Parse(quantidadeTextBox.Text);
                venda.Cliente.Codigo = (int)clienteComboBox.SelectedValue;
                venda.Produto.Codigo = (int)produtoComboBox.SelectedValue;
                venda.Data = DateTime.Now;
                venda.Faturado = false;
                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
