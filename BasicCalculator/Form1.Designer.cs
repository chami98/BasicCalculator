
namespace BasicCalculator
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.CalculationResultBox = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(12, 39);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(458, 22);
            this.UserInput.TabIndex = 0;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // CalculationResultBox
            // 
            this.CalculationResultBox.Location = new System.Drawing.Point(9, 76);
            this.CalculationResultBox.Name = "CalculationResultBox";
            this.CalculationResultBox.Size = new System.Drawing.Size(396, 23);
            this.CalculationResultBox.TabIndex = 1;
            this.CalculationResultBox.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.equalButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.dotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.button0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.addButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.button3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.button2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.button1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.subtractButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.button6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.button5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.button4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.button9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.button8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.button7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.PercentageButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(15, 102);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(455, 359);
            this.ButtonsPanel.TabIndex = 2;
            this.ButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(107, 65);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(229, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(107, 65);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // PercentageButton
            // 
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.Location = new System.Drawing.Point(342, 3);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(110, 65);
            this.PercentageButton.TabIndex = 3;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 65);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(116, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 65);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(229, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 65);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Location = new System.Drawing.Point(342, 74);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(110, 65);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 65);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(116, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 65);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(229, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 65);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractButton.Location = new System.Drawing.Point(342, 145);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(110, 65);
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(116, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(229, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(342, 216);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 65);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(116, 287);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(107, 69);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // dotButton
            // 
            this.dotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotButton.Location = new System.Drawing.Point(229, 287);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(107, 69);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.Location = new System.Drawing.Point(342, 287);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(110, 69);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = " =";
            this.equalButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.equalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(482, 473);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultBox);
            this.Controls.Add(this.UserInput);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label CalculationResultBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button MultiplyButton;
    }
}

