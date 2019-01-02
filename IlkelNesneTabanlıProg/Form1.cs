using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkelNesneTabanlıProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Id = { 1, 2, 3 };
        string[] Ad = { "Ali", "veli", "ahmet" };
       

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenId = Convert.ToInt32(txtBox.Text);
            if (girilenId == 1)
            {
                txtBoxID.Text = Ad[0];
             
            }
            else if (girilenId == 2)
            {
                txtBoxID.Text = Ad[1];
            }
            else
            {
                txtBoxID.Text = Ad[2];
            }

            //int girilenID= Convert.ToInt32(txtBoxID.Text);
            //int index = Array.IndexOf(Id, girilenID);
            //txtBoxAd.Text = Ad[index];
        }
    }
}
