﻿namespace Tema_buton_traducere
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_French = new System.Windows.Forms.CheckBox();
            this.checkBox_Russian = new System.Windows.Forms.CheckBox();
            this.checkBox_German = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox_French
            // 
            this.checkBox_French.AutoSize = true;
            this.checkBox_French.Location = new System.Drawing.Point(21, 110);
            this.checkBox_French.Name = "checkBox_French";
            this.checkBox_French.Size = new System.Drawing.Size(59, 17);
            this.checkBox_French.TabIndex = 2;
            this.checkBox_French.Text = "French";
            this.checkBox_French.UseVisualStyleBackColor = true;
            this.checkBox_French.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_Russian
            // 
            this.checkBox_Russian.AutoSize = true;
            this.checkBox_Russian.Location = new System.Drawing.Point(21, 133);
            this.checkBox_Russian.Name = "checkBox_Russian";
            this.checkBox_Russian.Size = new System.Drawing.Size(64, 17);
            this.checkBox_Russian.TabIndex = 3;
            this.checkBox_Russian.Text = "Russian";
            this.checkBox_Russian.UseVisualStyleBackColor = true;
            // 
            // checkBox_German
            // 
            this.checkBox_German.AutoSize = true;
            this.checkBox_German.Location = new System.Drawing.Point(21, 156);
            this.checkBox_German.Name = "checkBox_German";
            this.checkBox_German.Size = new System.Drawing.Size(63, 17);
            this.checkBox_German.TabIndex = 4;
            this.checkBox_German.Text = "German";
            this.checkBox_German.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBox_German);
            this.Controls.Add(this.checkBox_Russian);
            this.Controls.Add(this.checkBox_French);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Translate number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_French;
        private System.Windows.Forms.CheckBox checkBox_Russian;
        private System.Windows.Forms.CheckBox checkBox_German;
    }
}

