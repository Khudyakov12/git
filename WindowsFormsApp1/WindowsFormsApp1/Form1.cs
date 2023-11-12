using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputColor_Click(object sender, EventArgs e)
        {
            InputColor newForm = new InputColor();
            newForm.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {    
            if (Class1.left) 
            {
                left.BackColor = Color.FromArgb(Class1.color.Item1, Class1.color.Item2, Class1.color.Item3);
            }

            if (Class1.right)
            {
                right.BackColor = Color.FromArgb(Class1.color.Item1, Class1.color.Item2, Class1.color.Item3);
            }

        }

        private void Help_Click(object sender, EventArgs e)
        {
            FormHelp newForm = new FormHelp();
            newForm.Show();
        }
    }
}
