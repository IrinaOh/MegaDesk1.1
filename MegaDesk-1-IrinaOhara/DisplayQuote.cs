using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1_IrinaOhara
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }
    }
}
