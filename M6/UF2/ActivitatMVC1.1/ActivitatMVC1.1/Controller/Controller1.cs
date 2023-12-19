using ActivitatMVC1._1.Model;
using ActivitatMVC1._1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ActivitatMVC1._1.Controller
{
    internal class Controller1
    {
        Form1 f;
        Repository r;
        Author autor = new Author();
        Book llibre = new Book();
        int codi;

        public Controller1()
        {
            f = new Form1();
            r = new Repository();
            //InitListeners();   //Aixi fins que no clickis el autor no veus els llibres           
            InitListeners();
            LoadComboboxAuthors();
            LoadDGVBooksBooks();
            Application.Run(f);
        }

        void LoadData()
        {
            LoadComboboxAuthors();
            LoadDGVBooksBooks();
        }

        void LoadComboboxAuthors()
        {
            f.comboBox1.DataSource = r.GetAuthors();
            f.comboBox1.DisplayMember = "AuthorName";
            f.dgvAuthors.DataSource = r.GetAuthors();
            f.dgvAuthors.Columns["AuthorId"].Visible = false;
            f.dgvAuthors.Columns["Book"].Visible = false;
            f.cbAutorsBooks.DataSource = r.GetAuthors();
            f.cbAutorsBooks.DisplayMember = "AuthorName";
        }

        void LoadComboboxBooks()
        {
            f.comboBox2.DataSource = autor.Book.ToList();
            f.comboBox2.DisplayMember = "Title";
            f.dgvBooks.DataSource = r.GetBooks(codi);
           // f.dgvBooks.DataSource = autor.Book.ToList();    
            f.dgvBooks.Columns["BookId"].Visible = false;
            f.dgvBooks.Columns["AuthorId"].Visible = false;
            f.dgvBooks.Columns["Description"].Visible = false;
            f.dgvBooks.Columns["Price"].Visible = false;
            f.dgvBooks.Columns["Author"].Visible = false;
        }

        void LoadDescripcioPreu()
        {
            f.textBox1.Text = llibre.Description;
            f.textBox2.Text = llibre.Price.ToString();
        }

        void LoadDGVFiltre(String name)
        {
            f.dgvAuthors.DataSource = r.GetAuthorsContains(name);
            f.dgvAuthors.Columns["AuthorId"].Visible = false;
            f.dgvAuthors.Columns["Book"].Visible = false;
        }

        void LoadDGVBooksBooks()
        {
            f.dgvBooksBooks.DataSource = r.GetBooks();
            f.dgvBooksBooks.Columns["BookId"].Visible = false;
            f.dgvBooksBooks.Columns["AuthorId"].Visible = false;            
            f.dgvBooksBooks.Columns["Author"].Visible = false;
        }

        void LoadDGVBooksFiltre(String name)
        {
            f.dgvBooksBooks.DataSource = r.GetBooksContains(name);
            f.dgvBooksBooks.Columns["BookId"].Visible = false;
            f.dgvBooksBooks.Columns["AuthorId"].Visible = false;
            f.dgvBooksBooks.Columns["Author"].Visible = false;

        }

        void LoadTBBooks(int codi)  // falla al borrar perque agafa un null // esta mal porque lo busco en la base de datos y si estaba borrado no encontraba nada
        {
            f.tBTitleBooks.Text = r.GetBook(codi).Title.ToString();
            f.tBDescriptionBooks.Text = r.GetBook(codi).Description.ToString();
            f.tBPriceBooks.Text = r.GetBook(codi).Price.ToString();
            int id = (int) r.GetBook(codi).AuthorId;
            autor = r.GetAuthor(id);
            f.cbAutorsBooks.SelectedItem = autor;          
        }
        

        void InitListeners()
        {
            f.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            f.comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            f.dgvAuthors.SelectionChanged += dgvAuthors_SelectionChanged;    // selected changed
            f.tBFiltre.TextChanged += TBFiltre_TextChanged;
            f.bIns.Click += BIns_Click;
            f.bUpd.Click += BUpd_Click;
            f.bDel.Click += BDel_Click;
            f.bDAll.Click += BDAll_Click;
            f.dgvBooksBooks.SelectionChanged += DgvBooksBooks_SelectionChanged;
            f.tbFiltreBooks.TextChanged += TbFiltreBooks_TextChanged;
            f.bInsBooks.Click += BInsBooks_Click;
            f.bUpdBooks.Click += BUpdBooks_Click;
            f.bDelBooks.Click += BDelBooks_Click;
        }

        private void BDelBooks_Click(object sender, EventArgs e)
        {
            codi = Int32.Parse(f.dgvBooksBooks.CurrentRow.Cells["BookId"].Value.ToString());
            r.DeleteBook(codi);
            LoadDGVBooksBooks();

        }

        private void BUpdBooks_Click(object sender, EventArgs e)
        {
            codi = Int32.Parse(f.dgvBooksBooks.CurrentRow.Cells["BookId"].Value.ToString());
            String title = f.tBTitleBooks.Text.ToString();
            String description = f.tBDescriptionBooks.Text.ToString();
            decimal price = decimal.Parse(f.tBPriceBooks.Text.ToString());
            autor = f.cbAutorsBooks.SelectedItem as Author;
            r.UpdateBook(codi, title, description, price, autor);
            LoadData();
        }

        private void BInsBooks_Click(object sender, EventArgs e)
        {
            String title = f.tBTitleBooks.Text.ToString();
            String description = f.tBDescriptionBooks.Text.ToString();
            decimal price = decimal.Parse(f.tBPriceBooks.Text.ToString());
            autor = f.cbAutorsBooks.SelectedItem as Author;
            r.InsertBook(title, description, price, autor);
            LoadData();
        }

        private void TbFiltreBooks_TextChanged(object sender, EventArgs e)
        {
            if (f.chbActiuBooks.Checked)
            {
                String name = f.tbFiltreBooks.Text.ToString();
                LoadDGVBooksFiltre(name);
            }
            else
            {
                LoadData();
            }
        }

        private void DgvBooksBooks_SelectionChanged(object sender, EventArgs e)
        {            
           // codi = Int32.Parse(f.dgvBooksBooks.CurrentRow.Cells["BookId"].Value.ToString());
            llibre = f.dgvBooksBooks.CurrentRow.DataBoundItem as Book;
            f.tBTitleBooks.Text = llibre.Title.ToString();
            f.tBDescriptionBooks.Text = llibre.Description.ToString();
            f.tBPriceBooks.Text = llibre.Price.ToString();          
            
           // f.cbAutorsBooks.SelectedItem = autor;
           // LoadTBBooks(llibre.BookId);
            //if (llibre != null)
            //{
            //    LoadTBBooks(llibre.BookId);
            //}
            //else
            //{
            //    llibre = f.dgvBooksBooks.SelectedRows[1].DataBoundItem as Book;
            //    LoadTBBooks(llibre.BookId);
            //}

        }

        private void TBFiltre_TextChanged(object sender, EventArgs e)
        {
            if (f.chBActiu.Checked)
            {
                String name = f.tBFiltre.Text.ToString();
                LoadDGVFiltre(name);
            }
            else
            {
                LoadData();
            }
        }

        private void BDAll_Click(object sender, EventArgs e)
        {
            codi = Int32.Parse(f.dgvAuthors.Rows[f.dgvAuthors.CurrentRow.Index].Cells["AuthorId"].Value.ToString());
            r.DeleteBooks(codi);
            r.DeleteAuthor(codi);
            LoadData();
        }

        private void BDel_Click(object sender, EventArgs e)
        {
            codi = Int32.Parse(f.dgvAuthors.Rows[f.dgvAuthors.CurrentRow.Index].Cells["AuthorId"].Value.ToString());
            r.DeleteAuthor(codi);
            LoadData();
        }

        private void BUpd_Click(object sender, EventArgs e)
        {
            codi = Int32.Parse(f.dgvAuthors.Rows[f.dgvAuthors.CurrentRow.Index].Cells["AuthorId"].Value.ToString());
            String name = f.tbAuthor.Text.ToString();
            r.UpdateAuthor(codi,name);
            LoadData();
        }

        private void BIns_Click(object sender, EventArgs e)
        {
            String name = f.tbAuthor.Text.ToString();
            r.InsertAuthor(name);
            LoadData();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autor = f.comboBox1.SelectedItem as Author;     // (Author)f.comboBox1.SelectedItem  segona manera de fer un casting
            LoadComboboxBooks();
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            llibre = f.comboBox2.SelectedItem as Book;     // (Book)f.comboBox2.SelectedItem  segona manera de fer un casting
            LoadDescripcioPreu();   
        }

        void dgvAuthors_SelectionChanged(object sender, EventArgs e)
        {
            f.tbAuthor.Text = f.dgvAuthors.CurrentRow.Cells["AuthorName"].Value.ToString();
            codi = Int32.Parse(f.dgvAuthors.CurrentRow.Cells["AuthorId"].Value.ToString());
            //if (f.dgvAuthors!=null && f.dgvAuthors.SelectedRows[0] != null)
            //{
            //    autor = f.dgvAuthors.CurrentRow.DataBoundItem as Author;
            //}
            LoadComboboxBooks();            
        }


    }
}
