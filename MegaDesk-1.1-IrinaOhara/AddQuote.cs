using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk_1_IrinaOhara
{
    public partial class AddQuote : Form
    {
        public object errorProvider { get; private set; }
        public object QuoteAmount { get; private set; }

        DesktopMaterial material;

        public AddQuote()
        {
            InitializeComponent();
            //use List<T> to populate a combobox
            List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            surfaceMaterial.DataSource = MaterialList;
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
            string deskquotefile = @"quotes.txt";
            //DeskQuote.CalculateQuoteTotal() = QuoteAmount;
            //int numberOfDrawers = numberOfDrawers.SelectedValue;
            material = (DesktopMaterial)surfaceMaterial.SelectedValue;
            string deskquoterecord = string.Format("{0},{1},{2},{3},{4},{5}", (string)name.Text, DateTime.Now.ToLongDateString(), width.Text, depth.Text, numberOfDrawers.SelectedValue, material, rushOrder.SelectedValue, QuoteAmount);

            if (validation() == 0)
            {
                errorProvider1.Clear();
                DisplayQuote displayQuoteForm = new DisplayQuote();
                displayQuoteForm.Tag = this;
                displayQuoteForm.Show(this);
                Hide();
            }

            // Write quote to a file.
            if (!File.Exists(deskquotefile))
            {
                using (StreamWriter sw = File.CreateText(deskquotefile))
                {
                    sw.WriteLine(deskquoterecord);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(deskquotefile))
                {
                    sw.WriteLine(deskquoterecord);
                }
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
