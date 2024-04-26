using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input numbers
                ulong operand1 = ulong.Parse(txtOperand1.Text);
                ulong operand2 = ulong.Parse(txtOperand2.Text);

                // Perform operation based on selected operator
                ulong result = 0;
                string selectedOperator = cmbOperator.SelectedItem.ToString();
                switch (selectedOperator)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "x":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        // Check for division by zero
                        if (operand2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = operand1 / operand2;
                        break;
                }

                // Display result
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Input numbers are too large.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void lblOperand1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
