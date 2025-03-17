namespace GerenciamentoEscolar
{
    partial class FrmAltSenha
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
            this.txtBoxSenhaA = new System.Windows.Forms.TextBox();
            this.labelTurma = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxSenhaN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSenhaA
            // 
            this.txtBoxSenhaA.Location = new System.Drawing.Point(126, 22);
            this.txtBoxSenhaA.Name = "txtBoxSenhaA";
            this.txtBoxSenhaA.Size = new System.Drawing.Size(243, 20);
            this.txtBoxSenhaA.TabIndex = 4;
            // 
            // labelTurma
            // 
            this.labelTurma.AutoSize = true;
            this.labelTurma.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurma.Location = new System.Drawing.Point(25, 22);
            this.labelTurma.Name = "labelTurma";
            this.labelTurma.Size = new System.Drawing.Size(94, 20);
            this.labelTurma.TabIndex = 0;
            this.labelTurma.Text = "Senha atual:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSenhaN);
            this.groupBox1.Controls.Add(this.txtBoxSenhaA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelTurma);
            this.groupBox1.Location = new System.Drawing.Point(17, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Image = global::GerenciamentoEscolar.Properties.Resources.cancel;
            this.pictureBoxX.Location = new System.Drawing.Point(381, 9);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxX.TabIndex = 2;
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.Click += new System.EventHandler(this.pictureBoxX_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Leelawadee UI", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTitulo.Location = new System.Drawing.Point(84, 4);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(238, 41);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Redefinir senha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBoxX);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 51);
            this.panel1.TabIndex = 3;
            // 
            // txtBoxSenhaN
            // 
            this.txtBoxSenhaN.Location = new System.Drawing.Point(126, 55);
            this.txtBoxSenhaN.Name = "txtBoxSenhaN";
            this.txtBoxSenhaN.Size = new System.Drawing.Size(243, 20);
            this.txtBoxSenhaN.TabIndex = 6;
            this.txtBoxSenhaN.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senha nova:";
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.ForeColor = System.Drawing.Color.White;
            this.buttonRed.Location = new System.Drawing.Point(292, 196);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(124, 31);
            this.buttonRed.TabIndex = 7;
            this.buttonRed.Text = "Redefinir";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // FrmAltSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 253);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltSenha";
            this.Load += new System.EventHandler(this.FrmAltSenha_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSenhaA;
        private System.Windows.Forms.Label labelTurma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxSenhaN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRed;
    }
}