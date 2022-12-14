using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_n9rwd5.Models;

namespace zh_n9rwd5
{
    public partial class UserControl1 : UserControl
    {
        Models.ZhContext zhContext = new Models.ZhContext();



        public UserControl1()
        {
            InitializeComponent();
        }



     



        private void VásárlóSort()
        {
            var vásárló = from x in zhContext.Vásárló
                          where x.VásárlóNév.Contains(textBox1.Text)
                          select x;
            listBox1.DataSource = vásárló.ToList();
            listBox1.DisplayMember = "VásárlóNév";
        }



        private void VásárlóList()
        {
            var selected = (Vásárló)listBox1.SelectedItem;
            var tmp = from x in zhContext.Vásárló
                      where x.VásárlóNév == selected.VásárlóNév
                      select new Vásárló
                      {
                          VásárlóAzon = x.VásárlóAzon,
                          VásárlóNév = x.VásárlóNév,
                          VásárlóOrszág = x.VásárlóOrszág
                      };
            vásárlóBindingSource.DataSource = tmp.ToList();
        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {
            VásárlóSort();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            VásárlóSort();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VásárlóList();
        }
    }
}

