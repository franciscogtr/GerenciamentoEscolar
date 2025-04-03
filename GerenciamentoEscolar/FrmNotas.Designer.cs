namespace GerenciamentoEscolar
{
    partial class FrmNotas
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemov = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboAtv = new System.Windows.Forms.ComboBox();
            this.lblAtv = new System.Windows.Forms.Label();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbxSearchA = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(603, 108);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(325, 421);
            this.dgvAlunos.TabIndex = 6;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(373, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lançar Notas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 51);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GerenciamentoEscolar.Properties.Resources.cancel;
            this.pictureBox9.Location = new System.Drawing.Point(909, 8);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDisciplina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemov);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.lblNota);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.btnLancar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.cboCurso);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.cboAtv);
            this.groupBox1.Controls.Add(this.lblAtv);
            this.groupBox1.Controls.Add(this.cboTurma);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Location = new System.Drawing.Point(26, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboDisciplina.Location = new System.Drawing.Point(367, 21);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(163, 21);
            this.cboDisciplina.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Disciplina:";
            // 
            // btnRemov
            // 
            this.btnRemov.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemov.FlatAppearance.BorderSize = 0;
            this.btnRemov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemov.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemov.ForeColor = System.Drawing.Color.White;
            this.btnRemov.Location = new System.Drawing.Point(289, 124);
            this.btnRemov.Name = "btnRemov";
            this.btnRemov.Size = new System.Drawing.Size(105, 29);
            this.btnRemov.TabIndex = 27;
            this.btnRemov.Text = "Remover";
            this.btnRemov.UseVisualStyleBackColor = false;
            this.btnRemov.Click += new System.EventHandler(this.btnRemov_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(162, 124);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 29);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(336, 82);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(194, 20);
            this.txtNota.TabIndex = 24;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(285, 80);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(48, 20);
            this.lblNota.TabIndex = 23;
            this.lblNota.Text = "Nota:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 20);
            this.txtNome.TabIndex = 22;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(22, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 21;
            this.labelNome.Text = "Aluno:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancar.FlatAppearance.BorderSize = 0;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.White;
            this.btnLancar.Location = new System.Drawing.Point(26, 124);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(105, 29);
            this.btnLancar.TabIndex = 20;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(425, 124);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(105, 29);
            this.buttonLimpar.TabIndex = 16;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboCurso.Location = new System.Drawing.Point(78, 52);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(189, 21);
            this.cboCurso.TabIndex = 19;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(22, 51);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 20);
            this.lblCurso.TabIndex = 18;
            this.lblCurso.Text = "Curso:";
            // 
            // cboAtv
            // 
            this.cboAtv.FormattingEnabled = true;
            this.cboAtv.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboAtv.Location = new System.Drawing.Point(367, 51);
            this.cboAtv.Name = "cboAtv";
            this.cboAtv.Size = new System.Drawing.Size(163, 21);
            this.cboAtv.TabIndex = 17;
            // 
            // lblAtv
            // 
            this.lblAtv.AutoSize = true;
            this.lblAtv.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtv.Location = new System.Drawing.Point(285, 51);
            this.lblAtv.Name = "lblAtv";
            this.lblAtv.Size = new System.Drawing.Size(80, 20);
            this.lblAtv.TabIndex = 16;
            this.lblAtv.Text = "Atividade:";
            // 
            // cboTurma
            // 
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboTurma.Location = new System.Drawing.Point(85, 82);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(182, 21);
            this.cboTurma.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(22, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(59, 20);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Turma:";
            // 
            // tbxSearchA
            // 
            this.tbxSearchA.Location = new System.Drawing.Point(118, 8);
            this.tbxSearchA.Name = "tbxSearchA";
            this.tbxSearchA.Size = new System.Drawing.Size(199, 20);
            this.tbxSearchA.TabIndex = 6;
            this.tbxSearchA.TextChanged += new System.EventHandler(this.tbxSearchA_TextChanged);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAluno.Location = new System.Drawing.Point(6, 7);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(106, 20);
            this.lblAluno.TabIndex = 5;
            this.lblAluno.Text = "Buscar Aluno:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.tbxSearchA);
            this.groupBox2.Controls.Add(this.lblAluno);
            this.groupBox2.Location = new System.Drawing.Point(603, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 34);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(26, 244);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(558, 285);
            this.dgvNotas.TabIndex = 9;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 555);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtividades";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAtv;
        private System.Windows.Forms.Label lblAtv;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox tbxSearchA;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnRemov;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboDisciplina;
        private System.Windows.Forms.Label label1;
    }
}