namespace WinFormsLesson3
{
    partial class Form2
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
            this.lb_outText = new System.Windows.Forms.Label();
            this.lb_DRText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_outText
            // 
            this.lb_outText.AutoSize = true;
            this.lb_outText.Location = new System.Drawing.Point(227, 89);
            this.lb_outText.Name = "lb_outText";
            this.lb_outText.Size = new System.Drawing.Size(38, 15);
            this.lb_outText.TabIndex = 0;
            this.lb_outText.Text = "label1";
            // 
            // lb_DRText
            // 
            this.lb_DRText.AutoSize = true;
            this.lb_DRText.Location = new System.Drawing.Point(511, 89);
            this.lb_DRText.Name = "lb_DRText";
            this.lb_DRText.Size = new System.Drawing.Size(38, 15);
            this.lb_DRText.TabIndex = 1;
            this.lb_DRText.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_DRText);
            this.Controls.Add(this.lb_outText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_outText;
        private Label lb_DRText;
        private Button button1;
        private TextBox textBox1;
    }
}