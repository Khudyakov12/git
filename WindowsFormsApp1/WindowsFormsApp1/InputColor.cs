using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputColor : Form
    {

        public InputColor()
        {
            InitializeComponent();
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            int numericValue;
            if (int.TryParse(red.Text, out numericValue) & 
                int.TryParse(green.Text, out numericValue) & 
                int.TryParse(blue.Text, out numericValue) &
                int.Parse(red.Text) < 256 & int.Parse(red.Text) > -1 &
                int.Parse(green.Text) < 256 & int.Parse(green.Text) > -1 &
                int.Parse(blue.Text) < 256 & int.Parse(blue.Text) > -1)
            {
                Class1.color.Item1 = int.Parse(red.Text);
                Class1.color.Item2 = int.Parse(green.Text);
                Class1.color.Item3 = int.Parse(blue.Text);
                Class1.left = left.Checked;
                Class1.right = right.Checked;
                this.Close();
            }
        }
    }
}
