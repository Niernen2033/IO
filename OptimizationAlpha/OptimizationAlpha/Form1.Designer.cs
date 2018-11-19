namespace OptimizationAlpha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_function = new System.Windows.Forms.TextBox();
            this.button_find_min = new System.Windows.Forms.Button();
            this.button_find_max = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_function
            // 
            this.textBox_function.Location = new System.Drawing.Point(12, 12);
            this.textBox_function.Name = "textBox_function";
            this.textBox_function.Size = new System.Drawing.Size(913, 20);
            this.textBox_function.TabIndex = 0;
            this.textBox_function.TabStop = false;
            this.textBox_function.Text = "Write a function...";
            this.textBox_function.Click += new System.EventHandler(this.textBox_function_Text_Click);
            this.textBox_function.Leave += new System.EventHandler(this.textBox_function_Leave);
            // 
            // button_find_min
            // 
            this.button_find_min.Location = new System.Drawing.Point(931, 12);
            this.button_find_min.Name = "button_find_min";
            this.button_find_min.Size = new System.Drawing.Size(159, 23);
            this.button_find_min.TabIndex = 1;
            this.button_find_min.TabStop = false;
            this.button_find_min.Text = "Find min";
            this.button_find_min.UseVisualStyleBackColor = true;
            this.button_find_min.Click += new System.EventHandler(this.button_find_min_Click);
            // 
            // button_find_max
            // 
            this.button_find_max.Location = new System.Drawing.Point(1096, 12);
            this.button_find_max.Name = "button_find_max";
            this.button_find_max.Size = new System.Drawing.Size(159, 23);
            this.button_find_max.TabIndex = 2;
            this.button_find_max.TabStop = false;
            this.button_find_max.Text = "Find max";
            this.button_find_max.UseVisualStyleBackColor = true;
            this.button_find_max.Click += new System.EventHandler(this.button_find_max_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(1096, 586);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(159, 23);
            this.button_exit.TabIndex = 3;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 621);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_find_max);
            this.Controls.Add(this.button_find_min);
            this.Controls.Add(this.textBox_function);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_function;
        private System.Windows.Forms.Button button_find_min;
        private System.Windows.Forms.Button button_find_max;
        private System.Windows.Forms.Button button_exit;
    }
}

