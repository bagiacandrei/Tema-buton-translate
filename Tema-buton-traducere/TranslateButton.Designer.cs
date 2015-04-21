namespace Tema_buton_traducere
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
            this.checkBoxFrench = new System.Windows.Forms.CheckBox();
            this.checkBoxRussian = new System.Windows.Forms.CheckBox();
            this.checkBoxGerman = new System.Windows.Forms.CheckBox();
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
            // checkBoxFrench
            // 
            this.checkBoxFrench.AutoSize = true;
            this.checkBoxFrench.Location = new System.Drawing.Point(21, 110);
            this.checkBoxFrench.Name = "checkBoxFrench";
            this.checkBoxFrench.Size = new System.Drawing.Size(59, 17);
            this.checkBoxFrench.TabIndex = 2;
            this.checkBoxFrench.Text = "French";
            this.checkBoxFrench.UseVisualStyleBackColor = true;
            this.checkBoxFrench.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRussian
            // 
            this.checkBoxRussian.AutoSize = true;
            this.checkBoxRussian.Location = new System.Drawing.Point(21, 133);
            this.checkBoxRussian.Name = "checkBoxRussian";
            this.checkBoxRussian.Size = new System.Drawing.Size(64, 17);
            this.checkBoxRussian.TabIndex = 3;
            this.checkBoxRussian.Text = "Russian";
            this.checkBoxRussian.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerman
            // 
            this.checkBoxGerman.AutoSize = true;
            this.checkBoxGerman.Location = new System.Drawing.Point(21, 156);
            this.checkBoxGerman.Name = "checkBoxGerman";
            this.checkBoxGerman.Size = new System.Drawing.Size(63, 17);
            this.checkBoxGerman.TabIndex = 4;
            this.checkBoxGerman.Text = "German";
            this.checkBoxGerman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBoxGerman);
            this.Controls.Add(this.checkBoxRussian);
            this.Controls.Add(this.checkBoxFrench);
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
        private System.Windows.Forms.CheckBox checkBoxFrench;
        private System.Windows.Forms.CheckBox checkBoxRussian;
        private System.Windows.Forms.CheckBox checkBoxGerman;
    }
}

