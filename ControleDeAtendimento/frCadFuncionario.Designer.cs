namespace ControleDeAtendimento
{
    partial class frCadFuncionario
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
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxFunc = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mtxtSalario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 178);
            this.btnCancelar.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(151, 178);
            this.btnSalvar.TabIndex = 6;
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
            this.label3.Location = new System.Drawing.Point(218, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data de Nascimento";
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Location = new System.Drawing.Point(220, 63);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.Size = new System.Drawing.Size(102, 20);
            this.mtxtDataNasc.TabIndex = 1;
            this.mtxtDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefone";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(350, 63);
            this.mtxtTelefone.Mask = "0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefone.TabIndex = 2;
            this.mtxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Salário Base";
            // 
            // pictureBoxFunc
            // 
            this.pictureBoxFunc.ErrorImage = null;
            this.pictureBoxFunc.InitialImage = null;
            this.pictureBoxFunc.Location = new System.Drawing.Point(469, 30);
            this.pictureBoxFunc.Name = "pictureBoxFunc";
            this.pictureBoxFunc.Size = new System.Drawing.Size(141, 185);
            this.pictureBoxFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFunc.TabIndex = 26;
            this.pictureBoxFunc.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Especialidade";
            // 
            // cbxEspecialidade
            // 
            this.cbxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidade.FormattingEnabled = true;
            this.cbxEspecialidade.Location = new System.Drawing.Point(151, 116);
            this.cbxEspecialidade.Name = "cbxEspecialidade";
            this.cbxEspecialidade.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecialidade.TabIndex = 4;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(322, 116);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(104, 23);
            this.btnFoto.TabIndex = 5;
            this.btnFoto.Text = "Selecionar Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(24, 118);
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(100, 20);
            this.mtxtSalario.TabIndex = 28;
            this.mtxtSalario.TextChanged += new System.EventHandler(this.mtxtSalario_TextChanged);
            // 
            // frCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 225);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.cbxEspecialidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtDataNasc);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(655, 264);
            this.MinimumSize = new System.Drawing.Size(655, 264);
            this.Name = "frCadFuncionario";
            this.Text = "Cadastro de Funcionários";
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.mtxtDataNasc, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.mtxtTelefone, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pictureBoxFunc, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbxEspecialidade, 0);
            this.Controls.SetChildIndex(this.btnFoto, 0);
            this.Controls.SetChildIndex(this.mtxtSalario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEspecialidade;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox mtxtSalario;
    }
}