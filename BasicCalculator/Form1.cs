using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        #region clearing methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = String.Empty;
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.Length < this.UserInput.SelectionStart + 1)
                return;
                this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);
            
            
        }
        #endregion 
        #region number methods

        private void button8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        #endregion

        private void CalculateEquation()
        {
            
        }

        #region Operator Functions
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("X");
        }
        #endregion

        #region Private helpers
        private void FocusInputText()
        {
            this.UserInput.Focus();
        }

        private void InsertTextValue(string value)
        {
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);
        }
        #endregion
    }
}
