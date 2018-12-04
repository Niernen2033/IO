﻿namespace OptimizationAlpha
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_function = new System.Windows.Forms.TextBox();
            this.label_results = new System.Windows.Forms.Label();
            this.tabControl_chart = new System.Windows.Forms.TabControl();
            this.tabPage_2d = new System.Windows.Forms.TabPage();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_3d = new System.Windows.Forms.TabPage();
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.groupBox_functions = new System.Windows.Forms.GroupBox();
            this.textBox_Z_range_to = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Z_range_from = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Y_range_to = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Y_range_from = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_X_range_to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_two_var = new System.Windows.Forms.RadioButton();
            this.textBox_X_range_from = new System.Windows.Forms.TextBox();
            this.button_help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_variables = new System.Windows.Forms.ListBox();
            this.radioButton_one_var = new System.Windows.Forms.RadioButton();
            this.button_search = new System.Windows.Forms.Button();
            this.button_read_from_file = new System.Windows.Forms.Button();
            this.bestResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_3D = new DisplayFunction.FPanel();
            this.tabControl_chart.SuspendLayout();
            this.tabPage_2d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.tabPage_3d.SuspendLayout();
            this.groupBox_functions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_function
            // 
            this.textBox_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_function.Enabled = false;
            this.textBox_function.Location = new System.Drawing.Point(887, 195);
            this.textBox_function.Name = "textBox_function";
            this.textBox_function.Size = new System.Drawing.Size(276, 20);
            this.textBox_function.TabIndex = 0;
            this.textBox_function.TabStop = false;
            this.textBox_function.Text = "Write a function...";
            this.textBox_function.Click += new System.EventHandler(this.textBox_function_Text_Click);
            this.textBox_function.TextChanged += new System.EventHandler(this.textBox_function_TextChanged);
            this.textBox_function.Leave += new System.EventHandler(this.textBox_function_Leave);
            // 
            // label_results
            // 
            this.label_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_results.AutoSize = true;
            this.label_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_results.Location = new System.Drawing.Point(887, 247);
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
            this.tabControl_chart.Size = new System.Drawing.Size(881, 665);
            this.tabControl_chart.TabIndex = 6;
            // 
            // tabPage_2d
            // 
            this.tabPage_2d.Controls.Add(this.myChart);
            this.tabPage_2d.Location = new System.Drawing.Point(4, 22);
            this.tabPage_2d.Name = "tabPage_2d";
            this.tabPage_2d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_2d.Size = new System.Drawing.Size(873, 639);
            this.tabPage_2d.TabIndex = 0;
            this.tabPage_2d.Text = "2D";
            this.tabPage_2d.UseVisualStyleBackColor = true;
            this.tabPage_2d.Click += new System.EventHandler(this.tabPage_2d_Click);
            // 
            // myChart
            // 
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.myChart.Legends.Add(legend1);
            this.myChart.Location = new System.Drawing.Point(0, 0);
            this.myChart.Name = "myChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.myChart.Series.Add(series1);
            this.myChart.Size = new System.Drawing.Size(855, 599);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "chart1";
            // 
            // tabPage_3d
            // 
            this.tabPage_3d.Controls.Add(this.panel_3D);
            this.tabPage_3d.Location = new System.Drawing.Point(4, 22);
            this.tabPage_3d.Name = "tabPage_3d";
            this.tabPage_3d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_3d.Size = new System.Drawing.Size(873, 639);
            this.tabPage_3d.TabIndex = 1;
            this.tabPage_3d.Text = "3D";
            this.tabPage_3d.UseVisualStyleBackColor = true;
            this.tabPage_3d.Click += new System.EventHandler(this.tabPage_3d_Click);
            // 
            // listBox_results
            // 
            this.listBox_results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.Location = new System.Drawing.Point(887, 284);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(382, 342);
            this.listBox_results.TabIndex = 11;
            // 
            // groupBox_functions
            // 
            this.groupBox_functions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_functions.Controls.Add(this.textBox_Z_range_to);
            this.groupBox_functions.Controls.Add(this.label6);
            this.groupBox_functions.Controls.Add(this.textBox_Z_range_from);
            this.groupBox_functions.Controls.Add(this.label7);
            this.groupBox_functions.Controls.Add(this.textBox_Y_range_to);
            this.groupBox_functions.Controls.Add(this.label4);
            this.groupBox_functions.Controls.Add(this.textBox_Y_range_from);
            this.groupBox_functions.Controls.Add(this.label5);
            this.groupBox_functions.Controls.Add(this.textBox_X_range_to);
            this.groupBox_functions.Controls.Add(this.label2);
            this.groupBox_functions.Controls.Add(this.radioButton_two_var);
            this.groupBox_functions.Controls.Add(this.textBox_X_range_from);
            this.groupBox_functions.Controls.Add(this.button_help);
            this.groupBox_functions.Controls.Add(this.label1);
            this.groupBox_functions.Controls.Add(this.listBox_variables);
            this.groupBox_functions.Controls.Add(this.radioButton_one_var);
            this.groupBox_functions.Location = new System.Drawing.Point(887, 12);
            this.groupBox_functions.Name = "groupBox_functions";
            this.groupBox_functions.Size = new System.Drawing.Size(382, 176);
            this.groupBox_functions.TabIndex = 0;
            this.groupBox_functions.TabStop = false;
            this.groupBox_functions.Text = "Search function";
            // 
            // textBox_Z_range_to
            // 
            this.textBox_Z_range_to.Location = new System.Drawing.Point(276, 140);
            this.textBox_Z_range_to.Name = "textBox_Z_range_to";
            this.textBox_Z_range_to.Size = new System.Drawing.Size(100, 20);
            this.textBox_Z_range_to.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "to: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Z_range_from
            // 
            this.textBox_Z_range_from.Location = new System.Drawing.Point(135, 140);
            this.textBox_Z_range_from.Name = "textBox_Z_range_from";
            this.textBox_Z_range_from.Size = new System.Drawing.Size(100, 20);
            this.textBox_Z_range_from.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Range for Z from: ";
            // 
            // textBox_Y_range_to
            // 
            this.textBox_Y_range_to.Location = new System.Drawing.Point(276, 102);
            this.textBox_Y_range_to.Name = "textBox_Y_range_to";
            this.textBox_Y_range_to.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y_range_to.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "to: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Y_range_from
            // 
            this.textBox_Y_range_from.Location = new System.Drawing.Point(135, 102);
            this.textBox_Y_range_from.Name = "textBox_Y_range_from";
            this.textBox_Y_range_from.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y_range_from.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Range for Y from: ";
            // 
            // textBox_X_range_to
            // 
            this.textBox_X_range_to.Location = new System.Drawing.Point(276, 68);
            this.textBox_X_range_to.Name = "textBox_X_range_to";
            this.textBox_X_range_to.Size = new System.Drawing.Size(100, 20);
            this.textBox_X_range_to.TabIndex = 15;
            this.textBox_X_range_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_range_to_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "to: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // textBox_X_range_from
            // 
            this.textBox_X_range_from.Location = new System.Drawing.Point(135, 68);
            this.textBox_X_range_from.Name = "textBox_X_range_from";
            this.textBox_X_range_from.Size = new System.Drawing.Size(100, 20);
            this.textBox_X_range_from.TabIndex = 13;
            this.textBox_X_range_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_range_from_KeyPress);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_help.Location = new System.Drawing.Point(307, 10);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(69, 43);
            this.button_help.TabIndex = 8;
            this.button_help.TabStop = false;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Range for X from: ";
            // 
            // listBox_variables
            // 
            this.listBox_variables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_variables.Enabled = false;
            this.listBox_variables.FormattingEnabled = true;
            this.listBox_variables.Items.AddRange(new object[] {
            "f(x)=",
            "f(x, y)=",
            "f(x, y, z)="});
            this.listBox_variables.Location = new System.Drawing.Point(136, 10);
            this.listBox_variables.Name = "listBox_variables";
            this.listBox_variables.Size = new System.Drawing.Size(165, 43);
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
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Enabled = false;
            this.button_search.Location = new System.Drawing.Point(1169, 194);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 20);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_read_from_file
            // 
            this.button_read_from_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_read_from_file.Enabled = false;
            this.button_read_from_file.Location = new System.Drawing.Point(887, 221);
            this.button_read_from_file.Name = "button_read_from_file";
            this.button_read_from_file.Size = new System.Drawing.Size(382, 23);
            this.button_read_from_file.TabIndex = 10;
            this.button_read_from_file.Text = "Read from file";
            this.button_read_from_file.UseVisualStyleBackColor = true;
            this.button_read_from_file.Click += new System.EventHandler(this.button_read_from_file_Click);
            // 
            // bestResultLabel
            // 
            this.bestResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestResultLabel.AutoSize = true;
            this.bestResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestResultLabel.ForeColor = System.Drawing.Color.Green;
            this.bestResultLabel.Location = new System.Drawing.Point(75, 3);
            this.bestResultLabel.Name = "bestResultLabel";
            this.bestResultLabel.Size = new System.Drawing.Size(0, 13);
            this.bestResultLabel.TabIndex = 13;
            this.bestResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Best result: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bestResultLabel);
            this.panel1.Location = new System.Drawing.Point(887, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 33);
            this.panel1.TabIndex = 14;
            // 
            // panel_3D
            // 
            this.panel_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_3D.ColorBackgroundAxisStep = 3;
            this.panel_3D.Location = new System.Drawing.Point(8, 9);
            this.panel_3D.Name = "panel_3D";
            this.panel_3D.Size = new System.Drawing.Size(859, 622);
            this.panel_3D.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.button_read_from_file);
            this.Controls.Add(this.button_search);
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
            this.tabPage_2d.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.tabPage_3d.ResumeLayout(false);
            this.groupBox_functions.ResumeLayout(false);
            this.groupBox_functions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_read_from_file;
        private System.Windows.Forms.ListBox listBox_results;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_X_range_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_X_range_to;
        private System.Windows.Forms.Label bestResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Z_range_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Z_range_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Y_range_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Y_range_from;
        private System.Windows.Forms.Label label5;
        private DisplayFunction.FPanel panel_3D;
    }
}

