using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace LibManDA
{
    public partial class Container : Form
    {
        private List<Book> books;
        public Container()
        {            
            InitializeComponent();
            loadBookAndView();
        } 
        public void loadBookAndView()
        {
            this.bookGridView.Rows.Clear();
            books = Book.loadALlBook();
            this.bookGridView.ColumnCount = Book.attrCount;
            for (int i = 0; i < Book.attrCount; i++)
            {
                bookGridView.Columns[i].Name = Book.attrs[i];
                bookGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            if (books != null)
                foreach (Book book in books)
                {
                    bookGridView.Rows.Add(book.toArray());
                }
            this.bookGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.bookGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }        
        private void bookGridView_MouseClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                MenuItem miEdit = new MenuItem("Edit");
                MenuItem miDelete = new MenuItem("Delete");
                MenuItem miAdd = new MenuItem("Add");
                m.MenuItems.Add(miDelete);
                m.MenuItems.Add(miAdd);
                m.MenuItems.Add(miEdit);
                miEdit.Click += new System.EventHandler(this.editMenuItem_Click);
                miAdd.Click += new System.EventHandler(this.addMenuItem_Click);
                miDelete.Click += new System.EventHandler(this.deleteMenuItem_Click);
                int currentMouseOverRow = bookGridView.HitTest(e.X, e.Y).RowIndex;
                m.Show(bookGridView,new Point(e.X,e.Y));                
            }
        }
        private void deleteMenuItem_Click(Object sender, EventArgs e)              
        {
            int curentRow = bookGridView.CurrentCell.RowIndex;
            if (curentRow >= 0 && curentRow < books.Count)
            {
                Book book = books[curentRow];
                WebClient wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                NameValueCollection data = new NameValueCollection();
                data.Add("id", book.id);                                                             
                wc.Encoding = Encoding.UTF8;
                wc.UploadValues("https://soalibman.herokuapp.com/book/delete", data);
            }
            Program.container.loadBookAndView();
        }
        private void addMenuItem_Click(Object sender, EventArgs e)
        {
            EditForm ef = new EditForm();                                    
            ef.Show();
            Program.container.loadBookAndView();
        }
        private void editMenuItem_Click(Object sender, EventArgs e)
        {            
            EditForm ef = new EditForm();
            int curentRow = bookGridView.CurrentCell.RowIndex;
            Console.WriteLine(curentRow);
            if (curentRow >= 0 && curentRow < books.Count)
            {
                Book book = books[curentRow];
                ef.setData(book);
            }            
            ef.Show();
        }
    }
}
