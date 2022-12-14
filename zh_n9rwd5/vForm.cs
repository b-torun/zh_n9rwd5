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
    public partial class vForm : Form
    {
        Models.ZhContext zhContext= new Models.ZhContext();
        public vForm()
        {
            InitializeComponent();
        }

        private void vForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }
    }
}
