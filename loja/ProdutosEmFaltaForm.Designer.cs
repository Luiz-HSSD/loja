namespace Loja
{
    partial class ProdutosEmFaltaForm
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
            this.produtosEmFaltaLabel = new System.Windows.Forms.Label();
            this.produtosEmFaltaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produtosEmFaltaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosEmFaltaLabel
            // 
            this.produtosEmFaltaLabel.AutoSize = true;
            this.produtosEmFaltaLabel.Location = new System.Drawing.Point(13, 22);
            this.produtosEmFaltaLabel.Name = "produtosEmFaltaLabel";
            this.produtosEmFaltaLabel.Size = new System.Drawing.Size(154, 13);
            this.produtosEmFaltaLabel.TabIndex = 0;
            this.produtosEmFaltaLabel.Text = "Relatorio de produtos em Falta:";
            // 
            // produtosEmFaltaDataGridView
            // 
            this.produtosEmFaltaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtosEmFaltaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosEmFaltaDataGridView.Location = new System.Drawing.Point(4, 54);
            this.produtosEmFaltaDataGridView.Name = "produtosEmFaltaDataGridView";
            this.produtosEmFaltaDataGridView.Size = new System.Drawing.Size(478, 205);
            this.produtosEmFaltaDataGridView.TabIndex = 1;
            // 
            // ProdutosEmFaltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.produtosEmFaltaDataGridView);
            this.Controls.Add(this.produtosEmFaltaLabel);
            this.Name = "ProdutosEmFaltaForm";
            this.Text = "ProdutosEmFaltaForm";
            this.Load += new System.EventHandler(this.ProdutosEmFaltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosEmFaltaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label produtosEmFaltaLabel;
        private System.Windows.Forms.DataGridView produtosEmFaltaDataGridView;
    }
}