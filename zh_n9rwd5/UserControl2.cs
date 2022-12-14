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
    public partial class UserControl2 : UserControl
    {



        Models.ZhContext zhContext = new Models.ZhContext();
        public UserControl2()
        {
            InitializeComponent();
        }


            



      
        private void ÜgynökSort()
        {
            var ügynökök = from x in zhContext.Ügynökök
                           where x.ÜgynökNév.Contains(textBox1.Text)
                           select x;
            listBox1.DataSource = ügynökök.ToList();
            listBox1.DisplayMember = "ÜgynökNév";
        }



        private void ÜgynökList()
        {
            var selected = (Ügynökök)listBox1.SelectedItem;
            var tmp = from x in zhContext.Ügynökök
                      where x.ÜgynökNév == selected.ÜgynökNév
                      select new Ügynökök
                      {
                          ÜgynökAzon = x.ÜgynökAzon,
                          ÜgynökNév = x.ÜgynökNév,
                          Telefon = x.Telefon
                      };
            ügynökökBindingSource.DataSource = tmp.ToList();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ÜgynökSort();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ÜgynökList();
        }

        private void UserControl2_Load_1(object sender, EventArgs e)
        {
            ÜgynökSort();
        }
    }
}

