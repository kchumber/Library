using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Library
{
    public partial class libraryGUI : Form
    {
        Dictionary<string, Book> library = new Dictionary<string, Book>(StringComparer.InvariantCultureIgnoreCase);
        public libraryGUI()
        {
            InitializeComponent();
        }

        public void displayBooks()
        {
            libraryList.Items.Clear();
            ISBNtext.Clear();
            TITLEtext.Clear();

            foreach (KeyValuePair<string, Book> book in library)
            {
                libraryList.Items.Add(String.Format("{0} = {1}", book.Key, book.Value.Title));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ISBNtext.Text != "" && TITLEtext.Text != "")
            {
                library[ISBNtext.Text] = new Book(ISBNtext.Text, TITLEtext.Text);
                statusLabel.Text = String.Format("Added: {0} = {1}", ISBNtext.Text, TITLEtext.Text);
                displayBooks();
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN and Title";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            libraryList.Items.Clear();

            if (ISBNtext.Text != "")
            {
                foreach (KeyValuePair<string, Book> book in library)
                {
                    if (book.Key == ISBNtext.Text)
                    {
                        libraryList.Items.Add(String.Format("{0} = {1}", book.Key, book.Value.Title));
                        ISBNtext.Clear();
                    }
                    else
                    {
                        statusLabel.Text = String.Format("{0} not found", ISBNtext.Text);
                    }
                }
            }
            else if (TITLEtext.Text != "")
            {
                foreach (KeyValuePair<string, Book> book in library)
                {
                    if (book.Value.Title.ToLower().Contains(TITLEtext.Text.ToLower()))
                    {
                        libraryList.Items.Add(String.Format("{0} = {1}", book.Key, book.Value.Title));
                        TITLEtext.Clear();
                        statusLabel.Text = "";
                    }
                    else
                    {
                        statusLabel.Text = String.Format("{0} not found", TITLEtext.Text);
                    }
                }
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN or Title to search";
            }
        }

        //private void libraryGUI_Load(object sender, EventArgs e)
        //{
        //    Dictionary<string, Book> library = new Dictionary<string, Book>(StringComparer.InvariantCultureIgnoreCase);
        //}

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (ISBNtext.Text != "")
            {
                if (library.ContainsKey(ISBNtext.Text))
                {
                    library.Remove(ISBNtext.Text);
                    statusLabel.Text = String.Format("Removed: {0}", ISBNtext.Text);
                    displayBooks();
                }
                else
                {
                    statusLabel.Text = String.Format("{0} not found", ISBNtext.Text);
                }
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN";
            }
        }

        private void onLoanButton_Click(object sender, EventArgs e)
        {
            if (ISBNtext.Text != "")
            {
                if (library.ContainsKey(ISBNtext.Text))
                {
                    library[ISBNtext.Text].Onloan = true;
                    ISBNtext.Clear();
                }
                else
                {
                    statusLabel.Text = String.Format("{0} not found", ISBNtext.Text);
                }
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN";
            }
        }

        private void notOnLoanButton_Click(object sender, EventArgs e)
        {
            if (ISBNtext.Text != "")
            {
                if (library.ContainsKey(ISBNtext.Text))
                {
                    library[ISBNtext.Text].Onloan = false;
                    ISBNtext.Clear();
                }
                else
                {
                    statusLabel.Text = String.Format("{0} not found", ISBNtext.Text);
                }
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN";
            }
        }

        private void loanStatusButton_Click(object sender, EventArgs e)
        {
            if (ISBNtext.Text != "")
            {
                if (library.ContainsKey(ISBNtext.Text))
                {
                    if (library[ISBNtext.Text].Onloan == true)
                    {
                        statusLabel.Text = String.Format("{0} = {1} is currently on loan", library[ISBNtext.Text].ISBN, library[ISBNtext.Text].Title);
                        ISBNtext.Clear();
                    }
                    else
                    {
                        statusLabel.Text = String.Format("{0} = {1} is currently not on loan", library[ISBNtext.Text].ISBN, library[ISBNtext.Text].Title);
                        ISBNtext.Clear();
                    }
                }
                else
                {
                    statusLabel.Text = String.Format("{0} not found", ISBNtext.Text);
                }
            }
            else
            {
                statusLabel.Text = "Please enter an ISBN";
            }
        }
    }
}
