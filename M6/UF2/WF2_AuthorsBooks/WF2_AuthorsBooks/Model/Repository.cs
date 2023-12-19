using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2_AuthorsBooks.Model
{
    internal class Repository
    {
        AuthorBookEntities db;

        public void DbConnect()
        {
            db = new AuthorBookEntities();
        }

        public Repository()
        {
            DbConnect();
        }

        public List<Author> GetAuthors(string s)
        {
            List<Author> authors = new List<Author>();
            try
            {
                if (s == null)
                {
                    authors = db.Authors.OrderBy(a => a.AuthorName).ToList();
                }
                else
                {
                    authors = db.Authors.Where(a=>a.AuthorName.ToLower().Contains(s.ToLower())).OrderBy(a => a.AuthorName).ToList();
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
            }
            return authors;
        }

        public bool AuthorIns(Author au)
        {
            try
            {
                db.Authors.Add(au);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }

        public bool AuthorUpd(Author au, string s)
        {
            try
            {
                au.AuthorName = s;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }

        public bool AuthorDel(Author au, bool cascade)
        {
            try
            {
                if (cascade)
                {
                    if (au.Books!=null)
                    {
                        db.Books.RemoveRange(au.Books);
                    }
                }
                db.Authors.Remove(au);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }

        public List<Book> GetBooks(string s)
        {
            List<Book> books = new List<Book>();
            try
            {
                if (s == null)
                {
                    books = db.Books.OrderBy(a => a.Title).ToList();
                }
                else 
                {
                    books = db.Books.Where(a => a.Title.ToLower().Contains(s.ToLower())).OrderBy(a => a.Title).ToList();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
            }
            return books;
        }

        public List<Book> GetBooks(Author au)
        {
            List<Book> books = new List<Book>();
            try
            {
                if (au!=null && au.Books!=null)
                {
                    books = au.Books.OrderBy(a => a.Title).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
            }
            return books;
        }

        public bool BookIns(Book bo)
        {
            try
            {
                db.Books.Add(bo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }


        public bool BookUpd(Book bo, Book newbo)
        {
            try
            {
                bo.Update(newbo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }

        public bool BookDel(Book bo)
        {
            try
            {
                db.Books.Remove(bo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();
                return false;
            }
        }
    }


}

