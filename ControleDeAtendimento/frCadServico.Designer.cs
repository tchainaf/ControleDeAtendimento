namespace ControleDeAtendimento
{
    partial class frCadServico
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
            this.cbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Preço (R$)";
            // 
            // cbxEspecialidade
            // 
            this.cbxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidade.FormattingEnabled = true;
            this.cbxEspecialidade.Location = new System.Drawing.Point(351, 64);
            this.cbxEspecialidade.Name = "cbxEspecialidade";
            this.cbxEspecialidade.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecialidade.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Especialidade";
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Location = new System.Drawing.Point(223, 65);
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(100, 20);
            this.mtxtPreco.TabIndex = 23;
            this.mtxtPreco.TextChanged += new System.EventHandler(this.mtxtPreco_TextChanged);
            // 
            // frCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 145);
            this.Controls.Add(this.mtxtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEspecialidade);
            this.Controls.Add(this.label3);
            this.Name = "frCadServico";
            this.Text = "Cadastro de Serviços";
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbxEspecialidade, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.mtxtPreco, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEspecialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mtxtPreco;
    }
}