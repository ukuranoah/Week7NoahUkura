using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6NoahUkura
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecord temp = new SearchRecord();
            temp.ShowDialog();
        }
    }
    
}
