﻿namespace gameLearning
{
    partial class telaLogadoProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogadoProfessor));
            this.gameLearningLogoMenor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameLearningLogoMenor)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLearningLogoMenor
            // 
            this.gameLearningLogoMenor.BackColor = System.Drawing.Color.Transparent;
            this.gameLearningLogoMenor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameLearningLogoMenor.BackgroundImage")));
            this.gameLearningLogoMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameLearningLogoMenor.Location = new System.Drawing.Point(40, 37);
            this.gameLearningLogoMenor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameLearningLogoMenor.Name = "gameLearningLogoMenor";
            this.gameLearningLogoMenor.Size = new System.Drawing.Size(160, 74);
            this.gameLearningLogoMenor.TabIndex = 2;
            this.gameLearningLogoMenor.TabStop = false;
            // 
            // telaLogadoProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.gameLearningLogoMenor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 675);
            this.Name = "telaLogadoProfessor";
            this.Text = "telaLogadoProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.gameLearningLogoMenor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLearningLogoMenor;
    }
}