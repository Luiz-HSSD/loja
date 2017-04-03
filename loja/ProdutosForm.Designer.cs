namespace Loja
{
    partial class ProdutosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.lerButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesDataGridView.CausesValidation = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(16, 195);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(408, 233);
            this.clientesDataGridView.TabIndex = 27;
            // 
            // lerButton
            // 
            this.lerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lerButton.Location = new System.Drawing.Point(345, 434);
            this.lerButton.Name = "lerButton";
            this.lerButton.Size = new System.Drawing.Size(75, 23);
            this.lerButton.TabIndex = 26;
            this.lerButton.Text = "Ler";
            this.lerButton.UseVisualStyleBackColor = true;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(345, 146);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 25;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(102, 146);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 24;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(264, 146);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 23;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(183, 146);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 22;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(102, 112);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(102, 83);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(102, 51);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 19;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(102, 16);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 18;
            // 
            // estoqueLabel
            // 
            this.estoqueLabel.AutoSize = true;
            this.estoqueLabel.Location = new System.Drawing.Point(8, 115);
            this.estoqueLabel.Name = "estoqueLabel";
            this.estoqueLabel.Size = new System.Drawing.Size(49, 13);
            this.estoqueLabel.TabIndex = 17;
            this.estoqueLabel.Text = "Estoque:";
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(8, 83);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(38, 13);
            this.precoLabel.TabIndex = 16;
            this.precoLabel.Text = "Preço:";
            this.precoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(8, 51);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 15;
            this.nomeLabel.Text = "Nome:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(8, 19);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 14;
            this.codigoLabel.Text = "Código:";
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 473);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.lerButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.estoqueLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Button lerButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label estoqueLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label codigoLabel;
    }
}