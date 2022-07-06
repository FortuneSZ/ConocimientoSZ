using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            string selOperator = (string)(cmbOperator.SelectedItem);
            switch (selOperator)
            {
                case "+":
                    lblResult.Text = "" + (number1 + number2);
                    break;
                case "-":
                    lblResult.Text = "" + (number1 - number2);
                    break;
                case "*":
                    lblResult.Text = "" + (number1 * number2);
                    break;
                case "/":
                    lblResult.Text = "" + (number1 / number2);
                    break;
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
