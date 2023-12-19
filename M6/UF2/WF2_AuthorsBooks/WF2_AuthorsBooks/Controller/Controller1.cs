using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF2_AuthorsBooks.Model;

namespace WF2_AuthorsBooks.Controller
{
    internal class Controller1
    {
        Form1 f;
        Repository r;
        public Controller1() 
        {
            f = new Form1();
            r = new Repository();
            InitListeners();
            Application.Run(f);
        }

        void InitListeners()
        {
            // tab pages
            f.tpCombos.Enter += TabPage_Enter;
            f.tpAuthors.Enter += TabPage_Enter;
            f.tpBooks.Enter += TabPage_Enter;
            // combos
            f.cbAuthors.SelectedIndexChanged += cbCombos_SelectedIndexChanged;
            f.cbBooks.SelectedIndexChanged += cbCombos_SelectedIndexChanged;
            // authors
            f.dgvAuthors.SelectionChanged += dgv_SelectionChanged;
            f.dgvAuthors.DataSourceChanged += dgv_SelectionChanged;
            f.tbAuthorFilter.TextChanged += AuthorFilter;
            f.ckbAuthorFilter.CheckedChanged += AuthorFilter;
            f.btAuthorIns.Click += AuthorClick;
            f.btAuthorUpd.Click += AuthorClick;
            f.btAuthorDel.Click += AuthorClick;
            f.btAuthorDelAll.Click += AuthorClick;
            // books
            f.dgvBooks.SelectionChanged += dgv_SelectionChanged;
            f.dgvBooks.DataSourceChanged += dgv_SelectionChanged;
            f.tbBookFilter.TextChanged += BookFilter;
            f.ckbBookFilter.CheckedChanged += BookFilter;
            f.btBookIns.Click += BookClick;
            f.btBookUpd.Click += BookClick;
            f.btBookDel.Click += BookClick;
        }

        #region LoadData
        void LoadDataCombos()
        {
            f.cbAuthors.DataSource = r.GetAuthors(null);
            f.cbAuthors.DisplayMember = "AuthorName";
            f.cbBooks.DisplayMember = "Title";
        }

        void LoadDataAuthors(string s)
        {
            f.dgvAuthors.DataSource = r.GetAuthors(s);
            f.dgvAuthors.Columns["AuthorId"].Visible = false;
            f.dgvAuthors.Columns["Books"].Visible = false;
            f.dgvAuthorBooks.Columns["BookId"].Visible = false;
            f.dgvAuthorBooks.Columns["AuthorId"].Visible = false;
            f.dgvAuthorBooks.Columns["Author"].Visible = false;
        }

        void LoadDataBooks(string s)
        {
            List<Book> lb = r.GetBooks(s);
            f.dgvBooks.DataSource = lb;
            f.dgvBooks.Columns["BookId"].Visible = false;
            f.dgvBooks.Columns["AuthorId"].Visible = false;
            f.dgvBooks.Columns["Author"].Visible = false;
            if (lb == null || lb.Count==0) {
                f.cbBookAuthor.DataSource = new List<Book>();
            }
            else
            {
                f.cbBookAuthor.DataSource = r.GetAuthors(null);
            }
            f.cbBookAuthor.DisplayMember = "AuthorName";
        }

        void TabPage_Enter(object sender, EventArgs e)
        {
            if (((TabPage)sender).Name == "tpCombos")
            {
                LoadDataCombos();
            }
            else if (((TabPage)sender).Name == "tpAuthors")
            {
                LoadDataAuthors(null);
            }
            else if (((TabPage)sender).Name == "tpBooks")
            {
                LoadDataBooks(null);
            }
        }
        #endregion

        #region Combos
        void cbCombos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox) sender).Name=="cbAuthors")
            {
                Author au = (Author)f.cbAuthors.SelectedItem;
                if (au != null || au.Books != null)
                {
                    if (au.Books.Count == 0)
                    {
                        f.cbBooks.DataSource = null;
                        f.cbBooks.Items.Clear();
                    }
                    else
                    {
                        f.cbBooks.DataSource = au.Books.OrderBy(a => a.Title).ToList();
                    }
                }
            }
            else // combo Books
            {
                Book bo = (Book)f.cbBooks.SelectedItem;
                if (bo==null)
                {
                    f.tbDescrip.Text = "";
                    f.tbPrice.Text = "";
                }
                else
                {
                    f.tbDescrip.Text = bo.Description;
                    f.tbPrice.Text = bo.Price.ToString();
                }
            }
        }
        #endregion

        #region Authors
        void AuthorFilter(object sender, EventArgs e)
        {
            if (f.ckbAuthorFilter.Checked)
            {
                LoadDataAuthors(f.tbAuthorFilter.Text);
            }
            else
            {
                LoadDataAuthors(null);
            }
        }

        void AuthorClick(object sender, EventArgs e)
        {
            bool result = false;
            if (((Button)sender).Name =="btAuthorIns") 
            {
                result=r.AuthorIns(new Author(f.tbAuthor.Text));
            }
            else
            {
                DataGridViewRow row = f.dgvAuthors.CurrentRow;
                if (row != null)
                {
                    Author au = (Author)row.DataBoundItem;
                    if (((Button)sender).Name == "btAuthorUpd")
                    {
                        result=r.AuthorUpd(au, f.tbAuthor.Text);
                    }
                    else if (((Button)sender).Name == "btAuthorDel")
                    {
                        r.AuthorDel(au, false);
                    }
                    else if (((Button)sender).Name == "btAuthorDelAll")
                    {
                        result=r.AuthorDel(au, true);
                    }
                }
            }
            f.ckbAuthorFilter.Checked = true;
            f.ckbAuthorFilter.Checked = false;
        }
        #endregion

        #region Books
        void BookFilter(object sender, EventArgs e)
        {
            if (f.ckbBookFilter.Checked)
            {
                LoadDataBooks(f.tbBookFilter.Text);
            }
            else
            {
                LoadDataBooks(null);
            }
        }

        void BookClick(object sender, EventArgs e)
        {
            bool result = false;
            if (((Button)sender).Name == "btBookIns")
            {
                Author au = (Author)f.cbBookAuthor.SelectedItem;
                if (au!=null)
                {
                    result = r.BookIns(new Book(au.AuthorId, f.tbBookTitle.Text, f.tbBookDescription.Text, Int32.Parse(f.tbBookPrice.Text)));
                }
            }
            else
            {
                DataGridViewRow row = f.dgvBooks.CurrentRow;
                Author au = (Author)f.cbBookAuthor.SelectedItem;
                if (row != null && au!=null)
                {
                    Book bo = (Book)row.DataBoundItem;
                    if (((Button)sender).Name == "btBookUpd")
                    {
                        Book newbo = new Book(au.AuthorId, f.tbBookTitle.Text, f.tbBookDescription.Text, Decimal.Parse(f.tbBookPrice.Text));
                        result = r.BookUpd(bo, newbo); 
                    }
                    else if (((Button)sender).Name == "btBookDel")
                    {
                        result=r.BookDel(bo);
                    }
                }
            }
            f.ckbBookFilter.Checked = true;
            f.ckbBookFilter.Checked = false;
        }
        #endregion

        void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).Name == "dgvAuthors")
            {
                DataGridViewRow row = f.dgvAuthors.CurrentRow;
                if (row == null)
                {
                    f.tbAuthor.Text = "";
                    f.dgvAuthorBooks.DataSource = new List<Book>();
                }
                else { 
                    Author au = (Author)row.DataBoundItem;
                    if (au != null)
                    {
                        f.tbAuthor.Text = au.AuthorName;
                        f.dgvAuthorBooks.DataSource = r.GetBooks(au);
                    }
                }
            }
            else  // sender.Name == "dgvBooks"
            {
                DataGridViewRow row = f.dgvBooks.CurrentRow;
                if (row == null)
                {
                    f.tbBookTitle.Text = "";
                    f.tbBookDescription.Text = "";
                    f.tbBookPrice.Text = "";
                }
                else
                {
                    Book bo = (Book)row.DataBoundItem;
                    if (bo != null)
                    {
                        f.tbBookTitle.Text = bo.Title;
                        f.tbBookDescription.Text = bo.Description;
                        f.tbBookPrice.Text = bo.Price.ToString();
                        f.cbBookAuthor.SelectedItem = bo.Author;
                    }
                }
            }
        }


    }
}
