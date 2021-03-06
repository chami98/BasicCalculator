﻿using System;
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

            FocusInputText();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertTextValue("9");

            FocusInputText();
              
        }

        #region clearing methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = String.Empty;
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

            FocusInputText();


        }
        #endregion 
        #region number methods

        private void button8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            FocusInputText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            FocusInputText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            FocusInputText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            FocusInputText();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            InsertTextValue("1");

            FocusInputText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            FocusInputText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            FocusInputText();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            FocusInputText();
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            FocusInputText();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            FocusInputText();

        }

        #endregion

       

        #region Operator Functions
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");

            FocusInputText();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            FocusInputText();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            FocusInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("X");

            FocusInputText();
        }
        #endregion

        #region Private helpers
        private void FocusInputText()
        {
            this.UserInput.Focus();
        }

        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;
            
            // set new text
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);

            //restore the selection start
            this.UserInput.SelectionStart = selectionStart + value.Length;
            
            //set selection length to zero
            this.UserInput.SelectionLength = 0;
        }


        private void DeleteTextValue()
        {

            if (this.UserInput.Text.Length < this.UserInput.SelectionStart + 1)
            return;

            //Remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);

          
            //restore the selection start
            this.UserInput.SelectionStart = selectionStart;

            //set selection length to zero
            this.UserInput.SelectionLength = 0;
        }

        private void CalculateEquation()
        {
            var userInput = this.UserInput.Text;


            FocusInputText();

        }
        #endregion
    }
}
