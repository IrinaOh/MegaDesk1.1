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
            // DateTime date, int width, int depth, int drawers, DesktopMaterial material, int rushDays
        {

 
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }
    }
}
