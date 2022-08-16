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
    public partial class DisplayAll : Form
    {
        public DisplayAll()
        {
            InitializeComponent();
            table.DataSource = null;
            table.DataSource = Class1.getall();
        }
    }
}
