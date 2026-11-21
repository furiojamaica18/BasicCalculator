using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaclculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                float result = 0;
                switch (cmbOperator.SelectedItem.ToString())
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed.");
                            return;
                        }
                        result = BasicComputation.Division(num1, num2);
                        break;
                }
                lblTotal.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers...");
            }
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cmbOperator.Items.Clear();
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");
            cmbOperator.SelectedIndex = 0;
        }
    }
}
