namespace GerenciamentoEscolar
{
    partial class FrmAtividades
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
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnLimp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisc = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtAtv = new System.Windows.Forms.TextBox();
            this.btnRemov = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.dgvAtividade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GerenciamentoEscolar.Properties.Resources.cancel;
            this.pictureBox9.Location = new System.Drawing.Point(455, 8);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 51);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(120, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lançar Atividades";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(80, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Atividade:";
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimp.FlatAppearance.BorderSize = 0;
            this.btnLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimp.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.ForeColor = System.Drawing.Color.White;
            this.btnLimp.Location = new System.Drawing.Point(395, 202);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(92, 29);
            this.btnLimp.TabIndex = 26;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDisciplina);
            this.groupBox1.Controls.Add(this.lblDisc);
            this.groupBox1.Controls.Add(this.cboCurso);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.txtAtv);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboDisciplina.Location = new System.Drawing.Point(120, 79);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(321, 21);
            this.cboDisciplina.TabIndex = 19;
            this.cboDisciplina.SelectedIndexChanged += new System.EventHandler(this.cboDisciplina_SelectedIndexChanged);
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(39, 81);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(80, 20);
            this.lblDisc.TabIndex = 18;
            this.lblDisc.Text = "Disciplina:";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "Administrador",
            "Secretaria",
            "Comum"});
            this.cboCurso.Location = new System.Drawing.Point(88, 51);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(353, 21);
            this.cboCurso.TabIndex = 17;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(36, 50);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 20);
            this.lblCurso.TabIndex = 16;
            this.lblCurso.Text = "Curso:";
            // 
            // txtAtv
            // 
            this.txtAtv.Location = new System.Drawing.Point(114, 22);
            this.txtAtv.Name = "txtAtv";
            this.txtAtv.Size = new System.Drawing.Size(327, 20);
            this.txtAtv.TabIndex = 4;
            // 
            // btnRemov
            // 
            this.btnRemov.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemov.FlatAppearance.BorderSize = 0;
            this.btnRemov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemov.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemov.ForeColor = System.Drawing.Color.White;
            this.btnRemov.Location = new System.Drawing.Point(272, 202);
            this.btnRemov.Name = "btnRemov";
            this.btnRemov.Size = new System.Drawing.Size(92, 29);
            this.btnRemov.TabIndex = 25;
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
            this.btnEdit.Location = new System.Drawing.Point(149, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 29);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancar.FlatAppearance.BorderSize = 0;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.White;
            this.btnLancar.Location = new System.Drawing.Point(27, 202);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(92, 29);
            this.btnLancar.TabIndex = 23;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // dgvAtividade
            // 
            this.dgvAtividade.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividade.Location = new System.Drawing.Point(27, 249);
            this.dgvAtividade.Name = "dgvAtividade";
            this.dgvAtividade.Size = new System.Drawing.Size(460, 175);
            this.dgvAtividade.TabIndex = 27;
            this.dgvAtividade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtividade_CellContentClick);
            // 
            // FrmAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.dgvAtividade);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemov);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtividades";
            this.Load += new System.EventHandler(this.FrmAtividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAtv;
        private System.Windows.Forms.Button btnRemov;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.ComboBox cboDisciplina;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DataGridView dgvAtividade;
    }
}