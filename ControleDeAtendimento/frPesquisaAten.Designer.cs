namespace ControleDeAtendimento
{
    partial class frPesquisaAten
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbxTodosClientes = new System.Windows.Forms.CheckBox();
            this.cbxTodosFuncs = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "CPF do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Inicial";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(344, 319);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(91, 23);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Ver Detalhes";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            this.data,
            this.cliente,
            this.func,
            this.valorTotal,
            this.codCliente,
            this.codFunc});
            this.dataGridView1.Location = new System.Drawing.Point(22, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(553, 186);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // data
            // 
            this.data.DataPropertyName = "dt_atendimento";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 150;
            // 
            // func
            // 
            this.func.DataPropertyName = "func";
            this.func.HeaderText = "Funcionário";
            this.func.Name = "func";
            this.func.ReadOnly = true;
            this.func.Width = 150;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valor_total";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // codCliente
            // 
            this.codCliente.DataPropertyName = "cod_cliente";
            this.codCliente.HeaderText = "CodCliente";
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            this.codCliente.Visible = false;
            // 
            // codFunc
            // 
            this.codFunc.DataPropertyName = "cod_func";
            this.codFunc.HeaderText = "CodFunc";
            this.codFunc.Name = "codFunc";
            this.codFunc.ReadOnly = true;
            this.codFunc.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(484, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Funcionário";
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(23, 85);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(153, 21);
            this.cbxFuncionario.TabIndex = 19;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(296, 38);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 21;
            this.mtxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // cbxTodosClientes
            // 
            this.cbxTodosClientes.AutoSize = true;
            this.cbxTodosClientes.Checked = true;
            this.cbxTodosClientes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTodosClientes.Location = new System.Drawing.Point(412, 40);
            this.cbxTodosClientes.Name = "cbxTodosClientes";
            this.cbxTodosClientes.Size = new System.Drawing.Size(110, 17);
            this.cbxTodosClientes.TabIndex = 24;
            this.cbxTodosClientes.Text = "Todos os Clientes";
            this.cbxTodosClientes.UseVisualStyleBackColor = true;
            this.cbxTodosClientes.CheckedChanged += new System.EventHandler(this.cbxTodosClientes_CheckedChanged);
            // 
            // cbxTodosFuncs
            // 
            this.cbxTodosFuncs.AutoSize = true;
            this.cbxTodosFuncs.Checked = true;
            this.cbxTodosFuncs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTodosFuncs.Location = new System.Drawing.Point(191, 87);
            this.cbxTodosFuncs.Name = "cbxTodosFuncs";
            this.cbxTodosFuncs.Size = new System.Drawing.Size(133, 17);
            this.cbxTodosFuncs.TabIndex = 25;
            this.cbxTodosFuncs.Text = "Todos os Funcionários";
            this.cbxTodosFuncs.UseVisualStyleBackColor = true;
            this.cbxTodosFuncs.CheckedChanged += new System.EventHandler(this.cbxTodosFuncs_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(168, 319);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(23, 38);
            this.dtpDataInicial.MaxDate = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.dtpDataInicial.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(87, 20);
            this.dtpDataInicial.TabIndex = 27;
            this.dtpDataInicial.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(160, 38);
            this.dtpDataFinal.MaxDate = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.dtpDataFinal.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(87, 20);
            this.dtpDataFinal.TabIndex = 28;
            this.dtpDataFinal.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // frPesquisaAten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 354);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cbxTodosFuncs);
            this.Controls.Add(this.cbxTodosClientes);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frPesquisaAten";
            this.Text = "Pesquisa de Atendimentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.CheckBox cbxTodosClientes;
        private System.Windows.Forms.CheckBox cbxTodosFuncs;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn func;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFunc;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
    }
}