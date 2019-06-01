namespace ControleDeAtendimento
{
    partial class frSimulaAumento
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
            this.btnSimular = new System.Windows.Forms.Button();
            this.cbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoSimul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEspec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnSimular.Location = new System.Drawing.Point(362, 33);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(104, 23);
            this.btnSimular.TabIndex = 29;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // cbxEspecialidade
            // 
            this.cbxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidade.FormattingEnabled = true;
            this.cbxEspecialidade.Location = new System.Drawing.Point(31, 35);
            this.cbxEspecialidade.Name = "cbxEspecialidade";
            this.cbxEspecialidade.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecialidade.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Especialidade";
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
            this.precoAtual,
            this.precoSimul,
            this.codEspec});
            this.dataGridView1.Location = new System.Drawing.Point(22, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(444, 348);
            this.dataGridView1.TabIndex = 31;
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
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // precoAtual
            // 
            this.precoAtual.DataPropertyName = "preco";
            this.precoAtual.FillWeight = 120F;
            this.precoAtual.HeaderText = "Preço Atual (R$)";
            this.precoAtual.Name = "precoAtual";
            this.precoAtual.ReadOnly = true;
            this.precoAtual.Width = 110;
            // 
            // precoSimul
            // 
            this.precoSimul.DataPropertyName = "novoValor";
            this.precoSimul.FillWeight = 120F;
            this.precoSimul.HeaderText = "Preço Simulado (R$)";
            this.precoSimul.Name = "precoSimul";
            this.precoSimul.ReadOnly = true;
            this.precoSimul.Width = 130;
            // 
            // codEspec
            // 
            this.codEspec.DataPropertyName = "cod_espec";
            this.codEspec.HeaderText = "CodEspec";
            this.codEspec.Name = "codEspec";
            this.codEspec.ReadOnly = true;
            this.codEspec.Visible = false;
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(200, 35);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentagem.TabIndex = 32;
            this.txtPorcentagem.TextChanged += new System.EventHandler(this.txtPorcentagem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Porcentagem (%)";
            // 
            // frSimulaAumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.cbxEspecialidade);
            this.Controls.Add(this.label6);
            this.Name = "frSimulaAumento";
            this.Text = "Simula Alteração de Preços";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.ComboBox cbxEspecialidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoSimul;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEspec;
    }
}