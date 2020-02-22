using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Operations = new BitOperations();
            InitializeComponent();
        }

        private BitOperations Operations;

        

        private void button0_Click(object sender, EventArgs e)
        {
            if (!Operations.OperationFlag)
                LeftOperandLabel.Text += "0";
            else RigthOperation.Text += "0";
        }



        private void buttonOR_Click(object sender, EventArgs e)
        {
            if (LeftOperandLabel.Text != "" && RigthOperation.Text == "")
            {
                Operations.OperationFlag = true;
                Operations.Operation = "OR";
                OperationLabel.Text = Operations.Operation;
                Operations.LeftOperand = LeftOperandLabel.Text;
            }
        }

        private void buttonNot_Click(object sender, EventArgs e)
        {
            if (LeftOperandLabel.Text != "" && RigthOperation.Text == "")
            {
                Operations.OperationFlag = true;
                Operations.Operation = "NOT";
                OperationLabel.Text = Operations.Operation;
                Operations.NotOperation();
                Operations.LeftOperand = LeftOperandLabel.Text;
            }
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            if (LeftOperandLabel.Text != "" && RigthOperation.Text == "")
            {
                Operations.OperationFlag = true;
                Operations.Operation = "AND";
                OperationLabel.Text = Operations.Operation;
                Operations.LeftOperand = LeftOperandLabel.Text;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Operations.OperationFlag)
                LeftOperandLabel.Text += "1";
            else RigthOperation.Text += "1";
        }

        private void GetResultButton_Click(object sender, EventArgs e)
        {
            Operations.RightOperand = RigthOperation.Text;
            Operations.GetResult();
            ResultLabel.Text = Operations.Result;
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            LeftOperandLabel.Text = "";
            RigthOperation.Text = "";
            OperationLabel.Text = "";
            ResultLabel.Text = "";

            Operations.OperationFlag = false;
            Operations.Clear();
        }
    }
}
