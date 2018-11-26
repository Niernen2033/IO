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
            this.label_results = new System.Windows.Forms.Label();
            this.tabControl_chart = new System.Windows.Forms.TabControl();
            this.tabPage_2d = new System.Windows.Forms.TabPage();
            this.tabPage_3d = new System.Windows.Forms.TabPage();
            this.groupBox_functions = new System.Windows.Forms.GroupBox();
            this.radioButton_two_var = new System.Windows.Forms.RadioButton();
            this.listBox_variables = new System.Windows.Forms.ListBox();
            this.radioButton_one_var = new System.Windows.Forms.RadioButton();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_read_from_file = new System.Windows.Forms.Button();
            this.tabControl_chart.SuspendLayout();
            this.groupBox_functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_function
            // 
            this.textBox_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_function.Enabled = false;
            this.textBox_function.Location = new System.Drawing.Point(869, 90);
            this.textBox_function.Name = "textBox_function";
            this.textBox_function.Size = new System.Drawing.Size(301, 20);
            this.textBox_function.TabIndex = 0;
            this.textBox_function.TabStop = false;
            this.textBox_function.Text = "Write a function...";
            this.textBox_function.Click += new System.EventHandler(this.textBox_function_Text_Click);
            this.textBox_function.Leave += new System.EventHandler(this.textBox_function_Leave);
            // 
            // label_results
            // 
            this.label_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_results.AutoSize = true;
            this.label_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_results.Location = new System.Drawing.Point(869, 142);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(82, 25);
            this.label_results.TabIndex = 5;
            this.label_results.Text = "Results:";
            this.label_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_chart
            // 
            this.tabControl_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_chart.Controls.Add(this.tabPage_2d);
            this.tabControl_chart.Controls.Add(this.tabPage_3d);
            this.tabControl_chart.Location = new System.Drawing.Point(0, 0);
            this.tabControl_chart.Name = "tabControl_chart";
            this.tabControl_chart.SelectedIndex = 0;
            this.tabControl_chart.Size = new System.Drawing.Size(863, 621);
            this.tabControl_chart.TabIndex = 6;
            // 
            // tabPage_2d
            // 
            this.tabPage_2d.Location = new System.Drawing.Point(4, 22);
            this.tabPage_2d.Name = "tabPage_2d";
            this.tabPage_2d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_2d.Size = new System.Drawing.Size(855, 595);
            this.tabPage_2d.TabIndex = 0;
            this.tabPage_2d.Text = "2D";
            this.tabPage_2d.UseVisualStyleBackColor = true;
            this.tabPage_2d.Click += new System.EventHandler(this.tabPage_2d_Click);
            // 
            // tabPage_3d
            // 
            this.tabPage_3d.Location = new System.Drawing.Point(4, 22);
            this.tabPage_3d.Name = "tabPage_3d";
            this.tabPage_3d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_3d.Size = new System.Drawing.Size(855, 595);
            this.tabPage_3d.TabIndex = 1;
            this.tabPage_3d.Text = "3D";
            this.tabPage_3d.UseVisualStyleBackColor = true;
            this.tabPage_3d.Click += new System.EventHandler(this.tabPage_3d_Click);
            // 
            // groupBox_functions
            // 
            this.groupBox_functions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_functions.Controls.Add(this.radioButton_two_var);
            this.groupBox_functions.Controls.Add(this.button_help);
            this.groupBox_functions.Controls.Add(this.listBox_variables);
            this.groupBox_functions.Controls.Add(this.radioButton_one_var);
            this.groupBox_functions.Location = new System.Drawing.Point(869, 12);
            this.groupBox_functions.Name = "groupBox_functions";
            this.groupBox_functions.Size = new System.Drawing.Size(382, 72);
            this.groupBox_functions.TabIndex = 0;
            this.groupBox_functions.TabStop = false;
            this.groupBox_functions.Text = "Search function";
            // 
            // radioButton_two_var
            // 
            this.radioButton_two_var.AutoSize = true;
            this.radioButton_two_var.Location = new System.Drawing.Point(7, 42);
            this.radioButton_two_var.Name = "radioButton_two_var";
            this.radioButton_two_var.Size = new System.Drawing.Size(68, 17);
            this.radioButton_two_var.TabIndex = 2;
            this.radioButton_two_var.Text = "maximum";
            this.radioButton_two_var.UseVisualStyleBackColor = true;
            this.radioButton_two_var.CheckedChanged += new System.EventHandler(this.radioButton_two_var_CheckedChanged);
            // 
            // listBox_variables
            // 
            this.listBox_variables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_variables.Enabled = false;
            this.listBox_variables.FormattingEnabled = true;
            this.listBox_variables.Items.AddRange(new object[] {
            "f(x)=",
            "f(x, y)=",
            "f(x, y, z)=",
            "f(x, y, z, ...)="});
            this.listBox_variables.Location = new System.Drawing.Point(136, 10);
            this.listBox_variables.Name = "listBox_variables";
            this.listBox_variables.Size = new System.Drawing.Size(165, 56);
            this.listBox_variables.TabIndex = 3;
            this.listBox_variables.SelectedIndexChanged += new System.EventHandler(this.listBox_variables_SelectedIndexChanged);
            // 
            // radioButton_one_var
            // 
            this.radioButton_one_var.AutoSize = true;
            this.radioButton_one_var.Location = new System.Drawing.Point(7, 19);
            this.radioButton_one_var.Name = "radioButton_one_var";
            this.radioButton_one_var.Size = new System.Drawing.Size(65, 17);
            this.radioButton_one_var.TabIndex = 0;
            this.radioButton_one_var.Text = "minimum";
            this.radioButton_one_var.UseVisualStyleBackColor = true;
            this.radioButton_one_var.CheckedChanged += new System.EventHandler(this.radioButton_one_var_CheckedChanged);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(1176, 586);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(71, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.Location = new System.Drawing.Point(307, 10);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(71, 56);
            this.button_help.TabIndex = 8;
            this.button_help.TabStop = false;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Enabled = false;
            this.button_search.Location = new System.Drawing.Point(1176, 90);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(71, 20);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_read_from_file
            // 
            this.button_read_from_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_from_file.Enabled = false;
            this.button_read_from_file.Location = new System.Drawing.Point(869, 116);
            this.button_read_from_file.Name = "button_read_from_file";
            this.button_read_from_file.Size = new System.Drawing.Size(378, 23);
            this.button_read_from_file.TabIndex = 10;
            this.button_read_from_file.Text = "Read from file";
            this.button_read_from_file.UseVisualStyleBackColor = true;
            this.button_read_from_file.Click += new System.EventHandler(this.button_read_from_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 621);
            this.Controls.Add(this.button_read_from_file);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox_functions);
            this.Controls.Add(this.tabControl_chart);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.textBox_function);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.Text = "Extrema System Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl_chart.ResumeLayout(false);
            this.groupBox_functions.ResumeLayout(false);
            this.groupBox_functions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_function;
        private System.Windows.Forms.Label label_results;
        private System.Windows.Forms.TabControl tabControl_chart;
        private System.Windows.Forms.TabPage tabPage_2d;
        private System.Windows.Forms.TabPage tabPage_3d;
        private System.Windows.Forms.GroupBox groupBox_functions;
        private System.Windows.Forms.RadioButton radioButton_two_var;
        private System.Windows.Forms.RadioButton radioButton_one_var;
        private System.Windows.Forms.ListBox listBox_variables;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_read_from_file;
    }
}

