namespace Loja
{
    partial class VendasForm
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
            this.produtoLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.produtoComboBox = new System.Windows.Forms.ComboBox();
            this.incluirVendaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Location = new System.Drawing.Point(35, 64);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(47, 13);
            this.produtoLabel.TabIndex = 0;
            this.produtoLabel.Text = "Produto:";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(35, 37);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel.TabIndex = 1;
            this.clienteLabel.Text = "Cliente:";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(35, 95);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            this.quantidadeLabel.TabIndex = 2;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(106, 95);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 3;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DisplayMember = "Nome";
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.DropDownWidth = 300;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(106, 34);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(300, 21);
            this.clienteComboBox.TabIndex = 4;
            this.clienteComboBox.ValueMember = "Codigo";
            // 
            // produtoComboBox
            // 
            this.produtoComboBox.DisplayMember = "Nome";
            this.produtoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produtoComboBox.DropDownWidth = 300;
            this.produtoComboBox.FormattingEnabled = true;
            this.produtoComboBox.Location = new System.Drawing.Point(106, 64);
            this.produtoComboBox.Name = "produtoComboBox";
            this.produtoComboBox.Size = new System.Drawing.Size(300, 21);
            this.produtoComboBox.TabIndex = 5;
            this.produtoComboBox.ValueMember = "Codigo";
            // 
            // incluirVendaButton
            // 
            this.incluirVendaButton.Location = new System.Drawing.Point(106, 128);
            this.incluirVendaButton.Name = "incluirVendaButton";
            this.incluirVendaButton.Size = new System.Drawing.Size(171, 23);
            this.incluirVendaButton.TabIndex = 6;
            this.incluirVendaButton.Text = "Realizar Venda";
            this.incluirVendaButton.UseVisualStyleBackColor = true;
            this.incluirVendaButton.Click += new System.EventHandler(this.incluirVendaButton_Click);
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 161);
            this.Controls.Add(this.incluirVendaButton);
            this.Controls.Add(this.produtoComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.produtoLabel);
            this.Name = "VendasForm";
            this.Text = "VendasForm";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox produtoComboBox;
        private System.Windows.Forms.Button incluirVendaButton;
    }
}