using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh_n9rwd5
{
    public partial class rForm : Form
    {
        public rForm()
        {
            InitializeComponent();
        }

        private void rForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
    }
}
