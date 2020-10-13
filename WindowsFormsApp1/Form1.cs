using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void numberclick(object sender, EventArgs e)
        {
            btnResult.Enabled = true;
            btnResult.Enabled = true;
            btnplus.Enabled = true;
            btnmin.Enabled = true;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            Button btn = (Button)sender;
            textResult.Text += btn.Text;
            label.Text += btn.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnResult.Enabled = true;
            btnResult.Enabled = true;
            btnplus.Enabled = true;
            btnmin.Enabled = true;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            if (label.Text.Length != 0)
            {
              
                label.Text = label.Text.Substring(0, label.Text.Length - 1);
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            btnResult.Enabled = false;
            btnplus.Enabled = false;
            btnmin.Enabled = false;
            btndiv.Enabled = false;
            btnmul.Enabled = false;
            Button btn = (Button)sender;
            string s = btn.Text;
            switch (s)
            {
                case "+" : 
                    label2.Text += "+";
                 
                    break;
                case "-":
                    label2.Text += "-";
                   
                    break;
                case "x":
                    label2.Text += "*";
                   
                    break;
                case "/":
                    label2.Text += "/";
                
                    break;
            }
        }
        
        private void btnAC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }
    }
}
