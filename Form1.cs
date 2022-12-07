// Calculator Created by Ayman bouiraaman
// Copyright 2022-2023
// Note: Please get Permissions before using application!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_By_Ayman_Bouiraaman
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)

        {
            if ((Text_Button_Result.Text == "0") || (isOperationPerformed))
                Text_Button_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!Text_Button_Result.Text.Contains("."))
            Text_Button_Result.Text = Text_Button_Result.Text + button.Text;

            }else

            Text_Button_Result.Text = Text_Button_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        operationPerformed = button.Text;
        resultValue = Double.Parse(Text_Button_Result.Text);
        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
        isOperationPerformed = true;
    }

        private void button17_Click(object sender, EventArgs e)

        {
            Text_Button_Result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Text_Button_Result.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Text_Button_Result.Text=(resultValue + Double.Parse(Text_Button_Result.Text)).ToString();
                    break;

                case "-":
                    Text_Button_Result.Text=(resultValue - Double.Parse(Text_Button_Result.Text)).ToString();
                    break;

                case "*":
                    Text_Button_Result.Text=(resultValue * Double.Parse(Text_Button_Result.Text)).ToString();
                    break;

                case "/":
                    Text_Button_Result.Text=(resultValue / Double.Parse(Text_Button_Result.Text)).ToString();
                    break;
                    
                default:
                    break;




            }
        }


    }
}
