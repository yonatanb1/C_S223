using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searched  = Class1.findOne(searchTextBox.Text);
            if(searched != null)
            {
                MessageBox.Show("Your product exists");
            }
            else
            {
                MessageBox.Show("Product not found");
            }
            
        }
    }
}
