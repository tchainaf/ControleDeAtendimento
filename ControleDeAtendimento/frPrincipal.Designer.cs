namespace ControleDeAtendimento
{
    partial class frPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultAten = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSimulacao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInserirAten = new System.Windows.Forms.Button();
            this.btnNovoAten = new System.Windows.Forms.Button();
            this.btnExcluirAten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Funcionário";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(377, 109);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(196, 56);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cbxFuncionario.TabIndex = 2;
            this.cbxFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbxFuncionario_SelectedIndexChanged);
            // 
            // cbxServico
            // 
            this.cbxServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServico.Enabled = false;
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Location = new System.Drawing.Point(128, 111);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(189, 21);
            this.cbxServico.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "CPF do Ciente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.precoUnit,
            this.qtde,
            this.precoTotal,
            this.codAten,
            this.idDetalhe});
            this.dataGridView1.Location = new System.Drawing.Point(22, 162);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 187);
            this.dataGridView1.TabIndex = 28;
            // 
            // id
            // 
            this.id.DataPropertyName = "CodServico";
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 140;
            // 
            // precoUnit
            // 
            this.precoUnit.DataPropertyName = "PrecoUnit";
            this.precoUnit.FillWeight = 120F;
            this.precoUnit.HeaderText = "Preço Unitário";
            this.precoUnit.Name = "precoUnit";
            this.precoUnit.ReadOnly = true;
            this.precoUnit.Width = 120;
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "Qtde";
            this.qtde.FillWeight = 70F;
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 70;
            // 
            // precoTotal
            // 
            this.precoTotal.DataPropertyName = "PrecoTotal";
            this.precoTotal.FillWeight = 120F;
            this.precoTotal.HeaderText = "Preço Total";
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.ReadOnly = true;
            this.precoTotal.Width = 120;
            // 
            // codAten
            // 
            this.codAten.DataPropertyName = "CodAten";
            this.codAten.HeaderText = "CodAten";
            this.codAten.Name = "codAten";
            this.codAten.ReadOnly = true;
            this.codAten.Visible = false;
            // 
            // idDetalhe
            // 
            this.idDetalhe.DataPropertyName = "Id";
            this.idDetalhe.HeaderText = "CodDetalhe";
            this.idDetalhe.Name = "idDetalhe";
            this.idDetalhe.ReadOnly = true;
            this.idDetalhe.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Serviço:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(48, 56);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 0;
            this.mtxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncionarios,
            this.btnClientes,
            this.btnServicos,
            this.btnConsultAten,
            this.btnSimulacao,
            this.btnSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(87, 20);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(61, 20);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(62, 20);
            this.btnServicos.Text = "Serviços";
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnConsultAten
            // 
            this.btnConsultAten.Name = "btnConsultAten";
            this.btnConsultAten.Size = new System.Drawing.Size(94, 20);
            this.btnConsultAten.Text = "Atendimentos";
            this.btnConsultAten.Click += new System.EventHandler(this.btnConsultAten_Click);
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Size = new System.Drawing.Size(128, 20);
            this.btnSimulacao.Text = "Simulação de Preços";
            this.btnSimulacao.Click += new System.EventHandler(this.btnSimulacao_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(49, 20);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnInserirAten
            // 
            this.btnInserirAten.Location = new System.Drawing.Point(210, 369);
            this.btnInserirAten.Name = "btnInserirAten";
            this.btnInserirAten.Size = new System.Drawing.Size(127, 23);
            this.btnInserirAten.TabIndex = 5;
            this.btnInserirAten.Text = "Salvar Atendimento";
            this.btnInserirAten.UseVisualStyleBackColor = true;
            this.btnInserirAten.Click += new System.EventHandler(this.btnInserirAten_Click);
            // 
            // btnNovoAten
            // 
            this.btnNovoAten.Location = new System.Drawing.Point(369, 56);
            this.btnNovoAten.Name = "btnNovoAten";
            this.btnNovoAten.Size = new System.Drawing.Size(117, 23);
            this.btnNovoAten.TabIndex = 33;
            this.btnNovoAten.Text = "Novo Atendimento";
            this.btnNovoAten.UseVisualStyleBackColor = true;
            this.btnNovoAten.Visible = false;
            this.btnNovoAten.VisibleChanged += new System.EventHandler(this.btnNovoAten_VisibleChanged);
            this.btnNovoAten.Click += new System.EventHandler(this.btnNovoAten_Click);
            // 
            // btnExcluirAten
            // 
            this.btnExcluirAten.Location = new System.Drawing.Point(210, 369);
            this.btnExcluirAten.Name = "btnExcluirAten";
            this.btnExcluirAten.Size = new System.Drawing.Size(127, 23);
            this.btnExcluirAten.TabIndex = 34;
            this.btnExcluirAten.Text = "Excluir Atendimento";
            this.btnExcluirAten.UseVisualStyleBackColor = true;
            this.btnExcluirAten.Visible = false;
            this.btnExcluirAten.Click += new System.EventHandler(this.btnExcluirAten_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 409);
            this.Controls.Add(this.btnExcluirAten);
            this.Controls.Add(this.btnNovoAten);
            this.Controls.Add(this.cbxFuncionario);
            this.Controls.Add(this.btnInserirAten);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbxServico);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marido de Aluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem btnClientes;
        private System.Windows.Forms.ToolStripMenuItem btnServicos;
        private System.Windows.Forms.ToolStripMenuItem btnConsultAten;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
        private System.Windows.Forms.Button btnInserirAten;
        private System.Windows.Forms.ToolStripMenuItem btnSimulacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAten;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalhe;
        private System.Windows.Forms.Button btnNovoAten;
        private System.Windows.Forms.Button btnExcluirAten;
    }
}

