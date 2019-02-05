using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_1_IrinaOhara
{
    public partial class searchQuotes : Form
    {

        public searchQuotes()
        {
            InitializeComponent();
            //use List<T> to populate a combobox
            List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            searchInput.DataSource = MaterialList;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchResultView.Items.Clear();
            string Material = searchInput.SelectedItem.ToString();

            try
            {
                // Read quotes from the quotes text file and fill the ListView control with quotes that match
                // our search criteria.
                string quoteFile = @"quotes.txt";
                if (!File.Exists(quoteFile))
                {
                    MessageBox.Show("No quote file exists", "Error searching quotes");
                }
                else
                {
                    using (StreamReader sr = new StreamReader(quoteFile))
                    {
                        string quoteRow;
                        while (!sr.EndOfStream)
                        {
                            quoteRow = sr.ReadLine();
                            if (quoteRow.Contains(Material))
                            {
                                searchResultView.Items.Add(quoteRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Searching Quotes");
                throw;
            }

        }
    }
}
