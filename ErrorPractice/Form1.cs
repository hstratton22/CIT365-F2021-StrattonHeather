using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorPractice
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Form1()
        {

            //this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            errorProvider1 = new System.Windows.Forms.ErrorProvider();
            errorProvider1.SetIconAlignment (textBox1, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconPadding (textBox1, 2);
            errorProvider1.BlinkRate = 1000;
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, System.EventArgs e)//CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(textBox1.Text);
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, "Not an integer value.");
            }
        }
    }
}
