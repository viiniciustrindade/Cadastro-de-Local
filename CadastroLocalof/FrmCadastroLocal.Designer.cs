namespace CadastroLocalof
{
    partial class FrmCadastroLocal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroLocal));
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.txtCodLocal = new System.Windows.Forms.TextBox();
            this.txtDescLocal = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.asteriscoAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(16, 43);
            this.labelNomeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(110, 20);
            this.labelNomeAutor.TabIndex = 37;
            this.labelNomeAutor.Text = "Descrição local";
            // 
            // txtCodLocal
            // 
            this.txtCodLocal.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodLocal.Enabled = false;
            this.txtCodLocal.Location = new System.Drawing.Point(145, 15);
            this.txtCodLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodLocal.Name = "txtCodLocal";
            this.txtCodLocal.Size = new System.Drawing.Size(85, 22);
            this.txtCodLocal.TabIndex = 38;
            // 
            // txtDescLocal
            // 
            this.txtDescLocal.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescLocal.Location = new System.Drawing.Point(145, 43);
            this.txtDescLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescLocal.Multiline = true;
            this.txtDescLocal.Name = "txtDescLocal";
            this.txtDescLocal.Size = new System.Drawing.Size(432, 54);
            this.txtDescLocal.TabIndex = 39;
            this.txtDescLocal.TextChanged += new System.EventHandler(this.txtDescLocal_TextChanged);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(597, 43);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(101, 27);
            this.btn_Salvar.TabIndex = 40;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(597, 70);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(101, 27);
            this.btn_Excluir.TabIndex = 41;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLocal,
            this.colDescLocal});
            this.dadosGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid.Location = new System.Drawing.Point(20, 105);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(677, 247);
            this.dadosGrid.TabIndex = 42;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodLocal
            // 
            this.colCodLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodLocal.FillWeight = 152.2843F;
            this.colCodLocal.HeaderText = "Código";
            this.colCodLocal.MinimumWidth = 6;
            this.colCodLocal.Name = "colCodLocal";
            this.colCodLocal.ReadOnly = true;
            this.colCodLocal.Width = 80;
            // 
            // colDescLocal
            // 
            this.colDescLocal.FillWeight = 73.85786F;
            this.colDescLocal.HeaderText = "Descrição local";
            this.colDescLocal.MinimumWidth = 6;
            this.colDescLocal.Name = "colDescLocal";
            this.colDescLocal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Código";
            // 
            // asteriscoAlert
            // 
            this.asteriscoAlert.AutoSize = true;
            this.asteriscoAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asteriscoAlert.ForeColor = System.Drawing.Color.Red;
            this.asteriscoAlert.Location = new System.Drawing.Point(579, 43);
            this.asteriscoAlert.Name = "asteriscoAlert";
            this.asteriscoAlert.Size = new System.Drawing.Size(12, 16);
            this.asteriscoAlert.TabIndex = 45;
            this.asteriscoAlert.Text = "*";
            this.asteriscoAlert.MouseHover += new System.EventHandler(this.asteriscoAlert_MouseHover);
            // 
            // FrmCadastroLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(715, 367);
            this.Controls.Add(this.asteriscoAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txtDescLocal);
            this.Controls.Add(this.txtCodLocal);
            this.Controls.Add(this.labelNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro local";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.TextBox txtCodLocal;
        private System.Windows.Forms.TextBox txtDescLocal;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asteriscoAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescLocal;
    }
}

