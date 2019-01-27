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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide(); 
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
