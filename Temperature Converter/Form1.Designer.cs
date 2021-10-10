namespace Temperature_Converter
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
            this.Convert = new System.Windows.Forms.Button();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(120, 155);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(100, 23);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Location = new System.Drawing.Point(120, 73);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.Fahrenheit.TabIndex = 3;
            this.Fahrenheit.TextChanged += new System.EventHandler(this.Fahrenheit_TextChanged);
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(120, 114);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(100, 20);
            this.Celsius.TabIndex = 4;
            this.Celsius.TextChanged += new System.EventHandler(this.Celsius_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fahrenheit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celsius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Convert);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

