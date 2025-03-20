namespace GerenciamentoEscolar
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelGerenciamentoEscolar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelCadAlunos = new System.Windows.Forms.Label();
            this.labelAltSenha = new System.Windows.Forms.Label();
            this.labelRelatorios = new System.Windows.Forms.Label();
            this.labelEstatisticas = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.labelGerenciamentoEscolar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GerenciamentoEscolar.Properties.Resources.cancel;
            this.pictureBox9.Location = new System.Drawing.Point(758, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // labelGerenciamentoEscolar
            // 
            this.labelGerenciamentoEscolar.AutoSize = true;
            this.labelGerenciamentoEscolar.Font = new System.Drawing.Font("Leelawadee UI", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerenciamentoEscolar.ForeColor = System.Drawing.Color.White;
            this.labelGerenciamentoEscolar.Location = new System.Drawing.Point(234, -1);
            this.labelGerenciamentoEscolar.Name = "labelGerenciamentoEscolar";
            this.labelGerenciamentoEscolar.Size = new System.Drawing.Size(337, 41);
            this.labelGerenciamentoEscolar.TabIndex = 0;
            this.labelGerenciamentoEscolar.Text = "Gerenciamento Escolar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.labelData);
            this.panel2.Controls.Add(this.labelHora);
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 9;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelData.Location = new System.Drawing.Point(640, 13);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(77, 15);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "dd/mm/yyyy";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHora.Location = new System.Drawing.Point(727, 13);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(55, 15);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "00:00:00";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelUsuario.Location = new System.Drawing.Point(40, 13);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 15);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "NomeUsuario";
            // 
            // labelCadAlunos
            // 
            this.labelCadAlunos.AutoSize = true;
            this.labelCadAlunos.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelCadAlunos.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCadAlunos.Font = new System.Drawing.Font("Leelawadee UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadAlunos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCadAlunos.Location = new System.Drawing.Point(72, 3);
            this.labelCadAlunos.Name = "labelCadAlunos";
            this.labelCadAlunos.Size = new System.Drawing.Size(172, 46);
            this.labelCadAlunos.TabIndex = 10;
            this.labelCadAlunos.Text = "Cadastrar";
            // 
            // labelAltSenha
            // 
            this.labelAltSenha.AutoSize = true;
            this.labelAltSenha.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAltSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAltSenha.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltSenha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAltSenha.Location = new System.Drawing.Point(443, 389);
            this.labelAltSenha.Name = "labelAltSenha";
            this.labelAltSenha.Size = new System.Drawing.Size(83, 15);
            this.labelAltSenha.TabIndex = 14;
            this.labelAltSenha.Text = "Alterar Senha";
            // 
            // labelRelatorios
            // 
            this.labelRelatorios.AutoSize = true;
            this.labelRelatorios.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelRelatorios.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRelatorios.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelatorios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRelatorios.Location = new System.Drawing.Point(617, 210);
            this.labelRelatorios.Name = "labelRelatorios";
            this.labelRelatorios.Size = new System.Drawing.Size(65, 15);
            this.labelRelatorios.TabIndex = 15;
            this.labelRelatorios.Text = "Atividades";
            // 
            // labelEstatisticas
            // 
            this.labelEstatisticas.AutoSize = true;
            this.labelEstatisticas.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelEstatisticas.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEstatisticas.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstatisticas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelEstatisticas.Location = new System.Drawing.Point(446, 210);
            this.labelEstatisticas.Name = "labelEstatisticas";
            this.labelEstatisticas.Size = new System.Drawing.Size(78, 15);
            this.labelEstatisticas.TabIndex = 16;
            this.labelEstatisticas.Text = "Lançar Notas";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLogout.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLogout.Location = new System.Drawing.Point(626, 389);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(46, 15);
            this.labelLogout.TabIndex = 17;
            this.labelLogout.Text = "Logout";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.labelCadAlunos);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(73, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 54);
            this.panel3.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel7.Location = new System.Drawing.Point(418, 386);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 22);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel8.Location = new System.Drawing.Point(581, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(138, 22);
            this.panel8.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel9.Location = new System.Drawing.Point(418, 207);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(138, 22);
            this.panel9.TabIndex = 24;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel10.Location = new System.Drawing.Point(581, 386);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(138, 22);
            this.panel10.TabIndex = 25;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox5.BackgroundImage = global::GerenciamentoEscolar.Properties.Resources.logout;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(581, 252);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(138, 134);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox6.BackgroundImage = global::GerenciamentoEscolar.Properties.Resources.bar_chart;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(418, 73);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(138, 134);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox7.BackgroundImage = global::GerenciamentoEscolar.Properties.Resources.report;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(581, 73);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(138, 134);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox8.BackgroundImage = global::GerenciamentoEscolar.Properties.Resources.lockblue;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(418, 252);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(138, 134);
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BackgroundImage = global::GerenciamentoEscolar.Properties.Resources.student;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(73, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.labelEstatisticas);
            this.Controls.Add(this.labelRelatorios);
            this.Controls.Add(this.labelAltSenha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGerenciamentoEscolar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label labelCadAlunos;
        private System.Windows.Forms.Label labelAltSenha;
        private System.Windows.Forms.Label labelRelatorios;
        private System.Windows.Forms.Label labelEstatisticas;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer timerHora;
    }
}