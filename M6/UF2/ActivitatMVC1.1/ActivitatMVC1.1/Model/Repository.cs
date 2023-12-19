using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivitatMVC1._1.Model
{
    internal class Repository
    {

        AuthorBookEntities db;

        public Repository()
        {
            DbConnect();
        }

        void DbConnect()
        {
            db = new AuthorBookEntities();    // db variable de context
        }

        public List<Author> GetAuthors()        
        {
            List<Author> la = new List<Author>();                         // millor tornar una llista vuida que null
            try
            {
                la = db.Author.OrderBy(a => a.AuthorName).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return la;

        }

        public Author GetAuthor(int id)
        {
            Author au = new Author();                         // millor tornar una llista vuida que null
            try
            {
                au = db.Author.Where(a => a.AuthorId == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return au;

        }



        public List<Author> GetAuthorsContains(String name)
        {
            List<Author> la = new List<Author>();                         // millor tornar una llista vuida que null
            try
            {
                la = db.Author.Where(a=>a.AuthorName.Contains(name)).OrderBy(a => a.AuthorName).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return la;

        }

        public List<Book> GetBooks()
        {
            List<Book> lb = new List<Book>();                         // millor tornar una llista vuida que null
            try
            {
                lb = db.Book.OrderBy(a => a.Title).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return lb;

        }

        public List<Book> GetBooksContains(String name)
        {
            List<Book> lb = new List<Book>();                         // millor tornar una llista vuida que null
            try
            {
                lb = db.Book.Where(a=>a.Title.Contains(name)).OrderBy(a => a.Title).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return lb;

        }

        public List<Book> GetBooks(String autor)
        {
            List<Book> lb = new List<Book>();                         // millor tornar una llista vuida que null
            try
            {
                lb = db.Book.Where(a => a.Author.Equals(autor)).OrderBy(a => a.Title).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return lb;

        }

        public Book GetBook(int codi)
        {
            Book b = new Book();                         // millor tornar una llista vuida que null
            try
            {
                b = db.Book.Where(a => a.BookId == codi).FirstOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return b;

        }

        public List<Book> GetBooks(int codi)
        {
            List<Book> lb = new List<Book>();                         // millor tornar una llista vuida que null
            try
            {
                lb = db.Book.Where(a => a.AuthorId == codi).OrderBy(a => a.Title).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return lb;

        }

        public void InsertAuthor(String name)
        {            
            Author au = new Author();
            au.AuthorName = name;
            db.Author.Add(au);
            db.SaveChanges();
        }

        public void UpdateAuthor(int id ,String name)
        {
            Author au = new Author();
            au = db.Author.Where(a => a.AuthorId == id).FirstOrDefault();
            au.AuthorName = name;
            db.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Author au = new Author();
            au = db.Author.Where(a => a.AuthorId == id).FirstOrDefault();
            db.Author.Remove(au);
            db.SaveChanges();
        }

        public void DeleteBooks(int id)
        {
            Author au = new Author();
            au = db.Author.Where(a => a.AuthorId == id).FirstOrDefault();
            db.Book.RemoveRange(au.Book);
            db.SaveChanges();
        }

        public void InsertBook(String title, String Description, decimal price, Author author)
        {
            Book book = new Book();
            book.Title = title;
            book.Description = Description;
            book.Price = price;
            book.Author = author;
            db.Book.Add(book);
            db.SaveChanges();
        }

        public void UpdateBook(int id, String title, String Description, decimal price, Author author)
        {
            Book book = new Book();
            book = db.Book.Where(a => a.BookId == id).FirstOrDefault();
            book.Title = title;
            book.Description = Description;
            book.Price = price;
            book.Author = author;            
            db.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            Book book = new Book();
            book = db.Book.Where(a => a.BookId == id).FirstOrDefault();
            db.Book.Remove(book);
            db.SaveChanges();
        }

    }
}
