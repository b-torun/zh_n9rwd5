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
    public partial class üForm : Form
    {
        Models.ZhContext zhContext = new Models.ZhContext();
        public üForm()
        {
            InitializeComponent();
        }

        private void üForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }
    }
}
