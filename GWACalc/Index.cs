using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWACalc
{
    public partial class Index : KryptonForm
    {
        public Index()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ArrayList term = new ArrayList();
            term.Add("1Y, 1st Term");
            term.Add("1Y, 2nd Term");

            term.Add("2Y, 1st Term");
            term.Add("2Y, 2nd Term");

            term.Add("3Y, 1st Term");
            term.Add("3Y, 2nd Term");

            term.Add("4Y, 1st Term");

            foreach(string terms in term)
            {
                cmbTerms.Items.Add(terms);
                cmbTerms.AutoCompleteMode = AutoCompleteMode.None;
                cmbTerms.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            cmbTerms.SelectedIndex = 0;
        }

        private void cmbTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CalcModule(cmbTerms.Text).Show();
        }
    }
}
