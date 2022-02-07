namespace logical_operators
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
            this.label1 = new System.Windows.Forms.Label();
            this.cu_namre_textBox1 = new System.Windows.Forms.TextBox();
            this.cu_age_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Both";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // cu_namre_textBox1
            // 
            this.cu_namre_textBox1.Location = new System.Drawing.Point(117, 22);
            this.cu_namre_textBox1.Name = "cu_namre_textBox1";
            this.cu_namre_textBox1.Size = new System.Drawing.Size(158, 20);
            this.cu_namre_textBox1.TabIndex = 2;
            this.cu_namre_textBox1.Text = "bob";
            // 
            // cu_age_textBox2
            // 
            this.cu_age_textBox2.Location = new System.Drawing.Point(117, 60);
            this.cu_age_textBox2.Name = "cu_age_textBox2";
            this.cu_age_textBox2.Size = new System.Drawing.Size(158, 20);
            this.cu_age_textBox2.TabIndex = 4;
            this.cu_age_textBox2.Text = "21";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Age:";
            // 
            // name_textBox2
            // 
            this.name_textBox2.Location = new System.Drawing.Point(151, 221);
            this.name_textBox2.Name = "name_textBox2";
            this.name_textBox2.Size = new System.Drawing.Size(158, 20);
            this.name_textBox2.TabIndex = 7;
            this.name_textBox2.Text = "bob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Customer Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Check One";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 389);
            this.Controls.Add(this.name_textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cu_age_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cu_namre_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cu_namre_textBox1;
        private System.Windows.Forms.TextBox cu_age_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

