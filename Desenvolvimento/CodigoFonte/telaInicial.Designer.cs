﻿namespace gameLearning
{
    partial class telaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            this.logoMaior = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnSobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoMaior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // logoMaior
            // 
            this.logoMaior.BackColor = System.Drawing.Color.Transparent;
            this.logoMaior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoMaior.BackgroundImage")));
            this.logoMaior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoMaior.Location = new System.Drawing.Point(80, 50);
            this.logoMaior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoMaior.Name = "logoMaior";
            this.logoMaior.Size = new System.Drawing.Size(400, 250);
            this.logoMaior.TabIndex = 0;
            this.logoMaior.TabStop = false;
            this.logoMaior.Click += new System.EventHandler(this.logoMaior_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImage = global::gameLearning.Properties.Resources.btnCadastro;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastro.Location = new System.Drawing.Point(180, 500);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastro.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(180, 80);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.TabStop = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            this.btnCadastro.MouseLeave += new System.EventHandler(this.btnCadastro_MouseLeave);
            this.btnCadastro.MouseHover += new System.EventHandler(this.btnCadastro_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::gameLearning.Properties.Resources.btn_login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Location = new System.Drawing.Point(510, 500);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 80);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.BackgroundImage = global::gameLearning.Properties.Resources.btnSobre;
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSobre.Location = new System.Drawing.Point(830, 500);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSobre.MaximumSize = new System.Drawing.Size(180, 80);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(180, 80);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.TabStop = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            this.btnSobre.MouseLeave += new System.EventHandler(this.btnSobre_MouseLeave);
            this.btnSobre.MouseHover += new System.EventHandler(this.btnSobre_MouseHover);
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.logoMaior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 675);
            this.Name = "telaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.logoMaior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSobre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoMaior;
        private System.Windows.Forms.PictureBox btnCadastro;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.PictureBox btnSobre;
    }
}