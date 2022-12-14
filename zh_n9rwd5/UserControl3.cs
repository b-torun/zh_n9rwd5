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
    public partial class UserControl3 : UserControl
    {
        Models.ZhContext zhContext = new Models.ZhContext();
        public UserControl3()
        {
            InitializeComponent();
        }



        private void UserControl3_Load_1(object sender, EventArgs e)
        {
            VásárlóSort();
            ÜgynökSort();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VásárlóSort();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelésList();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ÜgynökSort();
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedVásárló = (Vásárló)listBox1.SelectedItem;
            var selectedÜgynök = (Ügynökök)listBox2.SelectedItem;



            mForm mform = new mForm();
            if (mform.ShowDialog() == DialogResult.OK)
            {
                Rendelések tmp = new Rendelések();
                tmp.RendelésAzon = Convert.ToInt32(mform.textBox1.Text);
                tmp.RendelésiMenny = Convert.ToInt32(mform.textBox2.Text);
                tmp.Előleg = Convert.ToInt32(mform.textBox3.Text);
                tmp.RendelésiDátum = Convert.ToDateTime(mform.dateTimePicker1);
                tmp.VásárlóAzon = selectedVásárló.VásárlóAzon;
                tmp.ÜgynökAzon = selectedÜgynök.ÜgynökAzon;



                zhContext.Rendelések.Add(tmp);
                try
                {
                    zhContext.SaveChanges();
                    MessageBox.Show("Sikeres mentés!");
                }
                catch (Exception)
                {



                    MessageBox.Show("Sikertelen!");
                }
            }



            else
            {



            }
            RendelésList();
        }



        private void buttonDel_Click(object sender, EventArgs e)
        {
            var selectedOrder = (Rendelések)rendelésekBindingSource.Current;
            var törlendőRendelés = (from x in zhContext.Rendelések
                                    where x.RendelésiMenny == selectedOrder.RendelésiMenny
                                    select x).FirstOrDefault();
            if (MessageBox.Show("Mented a változtatásokat?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;
            else
            {
                zhContext.Rendelések.Remove(törlendőRendelés);
                try
                {
                    zhContext.SaveChanges();
                    MessageBox.Show("Törölve!");
                }
                catch (Exception)
                {



                    MessageBox.Show("Siketelen!");
                }
                RendelésList();
            }
        }



        private void VásárlóSort()
        {
            var vásárló = from x in zhContext.Vásárló
                          where x.VásárlóNév.Contains(textBox1.Text)
                          select x;
            listBox1.DataSource = vásárló.ToList();
            listBox1.DisplayMember = "VásárlóNév";
        }





        private void ÜgynökSort()
        {
            var ügynökök = from x in zhContext.Ügynökök
                           where x.ÜgynökNév.Contains(textBox2.Text)
                           select x;
            listBox2.DataSource = ügynökök.ToList();
            listBox2.DisplayMember = "ÜgynökNév";
        }







        private void RendelésList()
        {
            var selected = (Vásárló)listBox1.SelectedItem;
            var tmp = from x in zhContext.Rendelések
                      where x.VásárlóAzon == selected.VásárlóAzon
                      select new Rendelések
                      {
                          RendelésAzon = x.RendelésAzon,
                          RendelésiMenny = x.RendelésiMenny,
                          Előleg = x.Előleg,
                          RendelésiDátum = x.RendelésiDátum,
                          VásárlóAzon = x.VásárlóAzon,
                          ÜgynökAzon = x.ÜgynökAzon
                      };
            rendelésekBindingSource.DataSource = tmp.ToList();
        }

        
    }
}
