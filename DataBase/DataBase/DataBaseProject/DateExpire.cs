using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class marfa_Alimentare : Form
    {
        public marfa_Alimentare()
        {
            InitializeComponent();
            lp_summa.Text = marfa.set_summ; //child
            
        }

        private void lp_summa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date_produce.Value = DateTime.Now;
            if (Date_produce.Value >= date_expire.Value)
            {
                lp_summa.Text = "0";
            }
            else
            {
                lp_summa.Text = marfa.set_summ;
            }
        }
    }
}
