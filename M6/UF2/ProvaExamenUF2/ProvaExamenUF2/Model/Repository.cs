using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaExamenUF2.Model
{
    internal class Repository
    {
        Contactes2Entities db;

        public Repository()
        {
            DbConnect();
        }

        void DbConnect()
        {
            db = new Contactes2Entities();    // db variable de context
        }

        public List<contacte> GetContactes()
        {
            List<contacte> con = new List<contacte>();                         // millor tornar una llista vuida que null
            try
            {
                con = db.contactes.OrderBy(a => a.cognoms).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return con;

        }

        public void InsertEmail(String email, int contacteId)
        {
            email e = new email();
            e.contacteId = contacteId;
            e.email1 = email;
            db.emails.Add(e);
            db.SaveChanges();
        }

        public void UpdateEmail(email e, String email)
        {
            //email em = new email();
           // em = db.emails.Where(a => a.emailId == e.emailId).FirstOrDefault();
            e.email1 = email;
            db.SaveChanges();
        }

        public void DeleteEmail(email e)
        {
           // email em = new email();
            //em = db.emails.Where(a => a.emailId == e.emailId).FirstOrDefault();
            db.emails.Remove(e);
            db.SaveChanges();
        }

        public void InsertTel(String tele, int contacteId)
        {
            telefon tel = new telefon();
            tel.contacteId = contacteId;
            tel.telefon1 = tele;
            db.telefons.Add(tel);
            db.SaveChanges();
        }

        public void UpdateTel(telefon t, String tele)
        {
            //telefon tel = new telefon();
            //tel = db.telefons.Where(a => a.telId == t.telId).FirstOrDefault();
            t.telefon1 = tele;
            db.SaveChanges();
        }

        public void DeleteTel(telefon t)
        {
           // telefon tel = new telefon();
           // tel = db.telefons.Where(a => a.telId == t.telId).FirstOrDefault();
            db.telefons.Remove(t);
            db.SaveChanges();
        }
    }
}
