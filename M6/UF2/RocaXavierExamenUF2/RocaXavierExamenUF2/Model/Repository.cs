using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocaXavierExamenUF2.Model
{
    internal class Repository
    {
        ciclismeEntities db;

        public Repository()
        {
            DbConnect();
        }

        void DbConnect()
        {
            db = new ciclismeEntities();    // db variable de context
        }

        public List<ciclista> GetCiclistes()
        {
            List<ciclista> cic = new List<ciclista>();                         // millor tornar una llista vuida que null
            try
            {
                cic = db.ciclistas.OrderBy(a => a.nombre).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return cic;
        }

        public List<etapa> GetEtapas(short dorsal)
        {
            List<etapa> et = new List<etapa>();                         // millor tornar una llista vuida que null
            try
            {
                et = db.ciclistas.Where(a=>a.dorsal == dorsal).SelectMany(a=>a.etapas).OrderBy(a => a.netapa).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return et;
        }

        public List<puerto> GetPuertos(short dorsal)
        {
            List<puerto> pu = new List<puerto>();                         // millor tornar una llista vuida que null
            try
            {
                pu = db.ciclistas.Where(a => a.dorsal == dorsal).SelectMany(a => a.puertoes).OrderBy(a => a.netapa).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return pu;
        }

        public List<equipo> GetEquipos()
        {
            List<equipo> cic = new List<equipo>();                         // millor tornar una llista vuida que null
            try
            {
                cic = db.equipoes.OrderBy(a => a.nomeq).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return cic;
        }

        public List<etapa> GetEquiposEtapaGuanyada(String nomequi)
        {
            List<etapa> et = new List<etapa>();                         // millor tornar una llista vuida que null
            try
            {
                et = db.equipoes.Where(a=>a.nomeq.Equals(nomequi)).SelectMany(a=>a.ciclistas).SelectMany(a=>a.etapas).OrderBy(a=>a.netapa).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return et;
        }

        public List<puerto> GetEquiposPuertosGuanyada(String nomequi)
        {
            List<puerto> pu = new List<puerto>();                         // millor tornar una llista vuida que null
            try
            {
                pu = db.equipoes.Where(a => a.nomeq.Equals(nomequi)).SelectMany(a => a.ciclistas).SelectMany(a => a.puertoes).OrderBy(a => a.netapa).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return pu;
        }

        public List<ciclista> GetEquiposCiclistas(String nomequi)
        {
            List<ciclista> c = new List<ciclista>();                         // millor tornar una llista vuida que null
            try
            {
                c = db.equipoes.Where(a => a.nomeq.Equals(nomequi)).SelectMany(a => a.ciclistas).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConnect();                        // Si hi ha error s'ha de crear una nova variable de context sino donara errors
            }
            return c;
        }





    }
}
