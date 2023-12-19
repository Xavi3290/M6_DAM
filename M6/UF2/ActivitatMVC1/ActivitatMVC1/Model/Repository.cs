using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivitatMVC1.Model
{
    internal class Repository
    {
        ChinookEntities db;   // db variable de context

        public Repository()
        {
            DbConnect();                // per que al inicialitzar sempre es conecti
        }

        void DbConnect()
        {
            db = new ChinookEntities();    // db variable de context
        }

        public List<Genre> GetGenres()
        {
            List<Genre> lg = new List<Genre>();                         // millor tornar una llista vuida que null
            try { 
                     lg = db.Genres.OrderBy(a=>a.Name).ToList();
                }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return lg;

        }

    }
}
