namespace GerenciamentoEscolar
{
    partial class FrmTurmas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTurma = new System.Windows.Forms.TextBox();
            this.labelTurma = new System.Windows.Forms.Label();
            this.btnLimpTurma = new System.Windows.Forms.Button();
            this.btnRemTurma = new System.Windows.Forms.Button();
            this.btnEdTurma = new System.Windows.Forms.Button();
            this.btnCadTurma = new System.Windows.Forms.Button();
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxBuscarT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(84, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cadastro de Turmas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 51);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GerenciamentoEscolar.Properties.Resources.cancel;
            this.pictureBox9.Location = new System.Drawing.Point(445, 8);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTurma);
            this.groupBox1.Controls.Add(this.labelTurma);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTurma
            // 
            this.textBoxTurma.Location = new System.Drawing.Point(171, 22);
            this.textBoxTurma.Name = "textBoxTurma";
            this.textBoxTurma.Size = new System.Drawing.Size(243, 20);
            this.textBoxTurma.TabIndex = 4;
            // 
            // labelTurma
            // 
            this.labelTurma.AutoSize = true;
            this.labelTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurma.Location = new System.Drawing.Point(36, 20);
            this.labelTurma.Name = "labelTurma";
            this.labelTurma.Size = new System.Drawing.Size(127, 20);
            this.labelTurma.TabIndex = 0;
            this.labelTurma.Text = "Nome da Turma:";
            // 
            // btnLimpTurma
            // 
            this.btnLimpTurma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpTurma.FlatAppearance.BorderSize = 0;
            this.btnLimpTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpTurma.ForeColor = System.Drawing.Color.White;
            this.btnLimpTurma.Location = new System.Drawing.Point(392, 148);
            this.btnLimpTurma.Name = "btnLimpTurma";
            this.btnLimpTurma.Size = new System.Drawing.Size(92, 29);
            this.btnLimpTurma.TabIndex = 13;
            this.btnLimpTurma.Text = "Limpar";
            this.btnLimpTurma.UseVisualStyleBackColor = false;
            this.btnLimpTurma.Click += new System.EventHandler(this.btnLimpTurma_Click);
            // 
            // btnRemTurma
            // 
            this.btnRemTurma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemTurma.FlatAppearance.BorderSize = 0;
            this.btnRemTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemTurma.ForeColor = System.Drawing.Color.White;
            this.btnRemTurma.Location = new System.Drawing.Point(269, 148);
            this.btnRemTurma.Name = "btnRemTurma";
            this.btnRemTurma.Size = new System.Drawing.Size(92, 29);
            this.btnRemTurma.TabIndex = 10;
            this.btnRemTurma.Text = "Remover";
            this.btnRemTurma.UseVisualStyleBackColor = false;
            this.btnRemTurma.Click += new System.EventHandler(this.btnRemTurma_Click);
            // 
            // btnEdTurma
            // 
            this.btnEdTurma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdTurma.FlatAppearance.BorderSize = 0;
            this.btnEdTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdTurma.ForeColor = System.Drawing.Color.White;
            this.btnEdTurma.Location = new System.Drawing.Point(146, 148);
            this.btnEdTurma.Name = "btnEdTurma";
            this.btnEdTurma.Size = new System.Drawing.Size(92, 29);
            this.btnEdTurma.TabIndex = 9;
            this.btnEdTurma.Text = "Editar";
            this.btnEdTurma.UseVisualStyleBackColor = false;
            this.btnEdTurma.Click += new System.EventHandler(this.btnEdTurma_Click);
            // 
            // btnCadTurma
            // 
            this.btnCadTurma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadTurma.FlatAppearance.BorderSize = 0;
            this.btnCadTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadTurma.ForeColor = System.Drawing.Color.White;
            this.btnCadTurma.Location = new System.Drawing.Point(24, 148);
            this.btnCadTurma.Name = "btnCadTurma";
            this.btnCadTurma.Size = new System.Drawing.Size(92, 29);
            this.btnCadTurma.TabIndex = 8;
            this.btnCadTurma.Text = "Cadastrar";
            this.btnCadTurma.UseVisualStyleBackColor = false;
            this.btnCadTurma.Click += new System.EventHandler(this.btnCadTurma_Click);
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            this.dataGridViewTurma.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Location = new System.Drawing.Point(24, 259);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.ReadOnly = true;
            this.dataGridViewTurma.Size = new System.Drawing.Size(460, 181);
            this.dataGridViewTurma.TabIndex = 15;
            this.dataGridViewTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTurma_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.txtBoxBuscarT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 34);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtBoxBuscarT
            // 
            this.txtBoxBuscarT.Location = new System.Drawing.Point(177, 9);
            this.txtBoxBuscarT.Name = "txtBoxBuscarT";
            this.txtBoxBuscarT.Size = new System.Drawing.Size(241, 20);
            this.txtBoxBuscarT.TabIndex = 6;
            this.txtBoxBuscarT.TextChanged += new System.EventHandler(this.txtBoxBuscarT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por Turma:";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 465);
            this.Controls.Add(this.dataGridViewTurma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpTurma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdTurma);
            this.Controls.Add(this.btnCadTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTurmas";
            this.Load += new System.EventHandler(this.FrmTurmas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTurma;
        private System.Windows.Forms.Label labelTurma;
        private System.Windows.Forms.Button btnLimpTurma;
        private System.Windows.Forms.Button btnRemTurma;
        private System.Windows.Forms.Button btnEdTurma;
        private System.Windows.Forms.Button btnCadTurma;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxBuscarT;
        private System.Windows.Forms.Label label1;
    }
}