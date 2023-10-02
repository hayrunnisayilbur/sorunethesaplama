using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorunet_hesaplama
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlis;
            double netDogru;

            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlis = Convert.ToInt32(cmbYanlis.Text);

            netDogru = dogru - yanlis / 4.0;

            lblNet.Text = "toplam net doğru :" + netDogru.ToString();
        }
    }
}
