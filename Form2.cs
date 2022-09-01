using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    
    public partial class Form2: Form
    {
        public class Book
        {
            public string ISBN;
            public string Title;
            public int catIndex;
            public int subcatIndex;
            public string authors;
            public DateTime purchasedon;
            public int type;
            public bool isIssued;
            public string issuedTo;
            public DateTime issuedOn;

            public Book(string _ISBN, string _title, int _cat, int _subcat, string _authors, DateTime _purchasedOn, int _type, bool _isIssued, string _issuedTo, DateTime _issuedDate)
            {
                ISBN = _ISBN;
                Title = _title;
                catIndex = _cat;
                subcatIndex = _subcat;
                authors = _authors;
                purchasedon = _purchasedOn;
                type = _type;
                isIssued = _isIssued;
                issuedTo = _issuedTo;
                issuedOn = _issuedDate;
            }
           
        }
        List<Book> books = new List<Book>();
        public Form2()
        {
            InitializeComponent();
            books.Add(new Book("0201144719 9780201144710", "An introduction to database systems", 1, 1, "C J Date", Convert.ToDateTime("1 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015"))); books.Add(new Book("0805301453 9780805301458", "Fundamentals of database systems", 1, 1, "Ramez Elmasri; Sham Navathe", Convert.ToDateTime("10 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1571690867 9781571690869", "Object oriented programming in Java", 2, 2, "Stephen Gilbert; Bill McCarty", Convert.ToDateTime("15 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1842652478 9781842652473", "Object oriented programming using C++", 2, 1, "B Chandra", Convert.ToDateTime("16 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0070522618 9780070522619", "Artificial intelligence", 3, 2, "Elaine Rich", Convert.ToDateTime("20 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0865760047 9780865760042", "The Handbook of artificial intelligence", 3, 2, "Avron Barr; Edward A Feigenbaum; Paul R Cohen", Convert.ToDateTime("22 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            foreach (Book b in books)
            {

                if (b.catIndex == 1)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                }
                else if (b.catIndex == 2)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                }
                else
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                }
            }
            this.comboBox1.Items.Add("Database Systems");
            this.comboBox1.Items.Add("OOP");
            this.comboBox1.Items.Add("Artificial Intelligence");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to delete this book?", "confirmation", MessageBoxButtons.YesNo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
