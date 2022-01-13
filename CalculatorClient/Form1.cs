using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numerator = Convert.ToInt32(txtNumerator.Text);
                int denominator = Convert.ToInt32(txtDenominator.Text);
                CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient();
                lblResult.Text = client.Divide(numerator, denominator).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }
    }
}
