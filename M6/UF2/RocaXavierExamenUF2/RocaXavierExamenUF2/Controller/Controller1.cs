using RocaXavierExamenUF2.Model;
using RocaXavierExamenUF2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocaXavierExamenUF2.Controller
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
            LoadData();
            Application.Run(f);
        }

        void LoadData()
        {
           // LoadEquipos();
            //LoadCiclistes();
            f.rbCiclistes.Checked = true;
        }

        void InitListeners()
        {
            // f.radioButton1.CheckedChanged += radioButton_CheckedChanged;
            f.rbEquips.CheckedChanged += RbEquips_CheckedChanged;
            f.rbCiclistes.CheckedChanged += RbEquips_CheckedChanged;
            f.dgvEquOCicl.SelectionChanged += DgvEquOCicl_SelectionChanged;

        }

        private void DgvEquOCicl_SelectionChanged(object sender, EventArgs e)
        {
            if (f.rbCiclistes.Name == "rbCiclistes")
            {
                ciclista c = new ciclista();
                c = f.dgvEquOCicl.CurrentRow.DataBoundItem as ciclista;
                LoadCiclistaEtapa(c);

                f.laCountEtapesGuanyades.Text = r.GetEtapas(c.dorsal).Count.ToString();

                LoadCiclistaPuerto(c);

                f.laPortsGuanyats.Text = r.GetPuertos(c.dorsal).Count.ToString();
            }
            else
            {
                equipo eq = new equipo();
                eq = f.dgvEquOCicl.CurrentRow.DataBoundItem as equipo;
                LoadEquiposEtapaGuanyada(eq);

                f.laCountEtapesGuanyades.Text = r.GetEquiposEtapaGuanyada(eq.nomeq).Count.ToString();

                LoadEquiposPuertosGanados(eq);

                f.laPortsGuanyats.Text = r.GetEquiposPuertosGuanyada(eq.nomeq).Count.ToString();

                LoadEquiposCiclistas(eq);

                f.laCiclistesEquip.Text = r.GetEquiposCiclistas(eq.nomeq).Count.ToString();
            }
        }
      

        private void RbEquips_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name == "rbCiclistes")
            {
                LoadCiclistes();               
            }
            else
            {
                LoadEquipos();               
            }
        }

        void LoadCiclistes()
        {
            f.dgvEquOCicl.DataSource = r.GetCiclistes();
            f.dgvEquOCicl.Columns["equipo"].Visible = false;
            f.dgvEquOCicl.Columns["etapas"].Visible = false;
            f.dgvEquOCicl.Columns["llevars"].Visible = false;
            f.dgvEquOCicl.Columns["puertoes"].Visible = false;

            f.laCountCiclistes.Text = r.GetCiclistes().Count.ToString();

        }

        void LoadEquipos()
        {
            f.dgvEquOCicl.DataSource = r.GetEquipos();
            f.dgvEquOCicl.Columns["ciclistas"].Visible = false;

            f.laCountCiclistes.Text = r.GetEquipos().Count.ToString();
        }

        void LoadEquiposEtapaGuanyada(equipo eq)
        {
            f.dgvEtapesGuanyades.DataSource = r.GetEquiposEtapaGuanyada(eq.nomeq);
            f.dgvEtapesGuanyades.Columns["ciclista"].Visible = false;
            f.dgvEtapesGuanyades.Columns["llevars"].Visible = false;
            f.dgvEtapesGuanyades.Columns["puertoes"].Visible = false;
        }

        void LoadEquiposPuertosGanados(equipo eq)
        {
            f.dgvPortsGuanyats.DataSource = r.GetEquiposPuertosGuanyada(eq.nomeq);
            f.dgvPortsGuanyats.Columns["ciclista"].Visible = false;
            f.dgvPortsGuanyats.Columns["etapa"].Visible = false;
        }

        void LoadEquiposCiclistas(equipo eq)
        {
            f.dgvCiclistesEquip.DataSource = r.GetEquiposCiclistas(eq.nomeq);
            f.dgvCiclistesEquip.Columns["etapas"].Visible = false;
            f.dgvCiclistesEquip.Columns["llevars"].Visible = false;
            f.dgvCiclistesEquip.Columns["puertoes"].Visible = false;
            f.dgvCiclistesEquip.Columns["equipo"].Visible = false;
        }

        void LoadCiclistaEtapa(ciclista c)
        {
            f.dgvEtapesGuanyades.DataSource = r.GetEtapas(c.dorsal);
            f.dgvEtapesGuanyades.Columns["ciclista"].Visible = false;
            f.dgvEtapesGuanyades.Columns["llevars"].Visible = false;
            f.dgvEtapesGuanyades.Columns["puertoes"].Visible = false;
        }

        void LoadCiclistaPuerto(ciclista c)
        {
            f.dgvPortsGuanyats.DataSource = r.GetPuertos(c.dorsal);
            f.dgvPortsGuanyats.Columns["ciclista"].Visible = false;
            f.dgvPortsGuanyats.Columns["etapa"].Visible = false;
        }

       
    }
}
