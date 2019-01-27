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
        public object errorProvider { get; private set; }

        public AddQuote()
        {
            InitializeComponent();
        }

         public int validation()
         {
             int flag = 0;
             int x = 0;
            
            //width cannot be empty
            if (width.Text == "")
             {
                 width.Focus();
                 errorProvider1.SetError(width, MessageBox.Show("Please enter width in inches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                 flag = 1;
             }
             //must be an integer
             else if(!int.TryParse(width.Text, out x))
             {
                 width.Focus();
                 errorProvider1.SetError(width, MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                 flag = 1;
             }
             //must be within a certain range
             /*else if(Desk.MINWIDTH > int.Parse(width.Text) && int.Parse(width.Text) > Desk.MAXWIDTH)
             {
                width.Focus();
                errorProvider1.SetError(width, MessageBox.Show("Width cannot be less than 24in and greater than 96in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }*/
            return flag;
         } 

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            if(validation() == 0)
            {
                errorProvider1.Clear();
                DisplayQuote displayQuoteForm = new DisplayQuote();
                displayQuoteForm.Tag = this;
                displayQuoteForm.Show(this);
                Hide();
            } 
        }



        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
