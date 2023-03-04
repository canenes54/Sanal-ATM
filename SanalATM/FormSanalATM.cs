using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalATM
{
    public partial class FormSanalATM : Form
    {
        public static int bakiye = 0;

        public FormSanalATM()
        {
            InitializeComponent();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paraYatır_Click(object sender, EventArgs e)
        {
            try
            {
                bakiye += Convert.ToInt32(tutarTextBox.Text);
                bakiyeLbl.Text = bakiye.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli tutar giriniz.","Uyarı");
            }
            
        }

        private void paraCek_Click(object sender, EventArgs e)
        {
            try
            {
                if (bakiye >= Convert.ToInt32(tutarTextBox.Text))
                {
                    bakiye -= Convert.ToInt32(tutarTextBox.Text);
                    bakiyeLbl.Text = bakiye.ToString();
                }
                else
                {
                    MessageBox.Show("Girilen tutar bakiyeniden yüksek olmalıdır.", "Uyarı");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli tutar giriniz.");
            }
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            bakiyeLbl.Text = bakiye.ToString();
        }
    }
}
