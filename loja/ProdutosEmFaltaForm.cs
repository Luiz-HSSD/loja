using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class ProdutosEmFaltaForm : Form
    {
        public ProdutosEmFaltaForm()
        {
            InitializeComponent();
        }
        private void ProdutosEmFaltaForm_Load(object sender, EventArgs e)
        {
            ProdutosBLL produto = new ProdutosBLL();
            produtosEmFaltaDataGridView.DataSource = produto.ProdutosEmFalta();
        }
    }
}

