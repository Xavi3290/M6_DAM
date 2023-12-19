using ProvaExamenUF2.Model;
using ProvaExamenUF2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaExamenUF2.Controller
{
    internal class Controller1
    {
        Form1 f;
        Repository r;
        contacte con;
        

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
            LoadContactes();
        }

        void InitListeners()
        {
            f.lbContactes.SelectedIndexChanged += LbContactes_SelectedIndexChanged;
            f.dgvEmails.SelectionChanged += DgvEmails_SelectionChanged;
            f.cbTelefons.SelectedIndexChanged += CbTelefons_SelectedIndexChanged;
            f.bAfegirEmail.Click += BAfegirEmail_Click;
            f.bUpdateEmail.Click += BUpdateEmail_Click;
            f.bDeleteEmail.Click += BDeleteEmail_Click;
            f.bAfegirTelefon.Click += BAfegirTelefon_Click;
            f.bUpdateTelefon.Click += BUpdateTelefon_Click;
            f.bDeleteTelefon.Click += BDeleteTelefon_Click;
        }

        private void BDeleteTelefon_Click(object sender, EventArgs e)
        {
            if (f.cbTelefons.Items.Count == 0)
            {
                MessageBox.Show("No estas eliminant res");
            }
            else
            {
                telefon tel = new telefon();
                tel = f.cbTelefons.SelectedItem as telefon;           
                r.DeleteTel(tel);
                LoadData();           
            }
        }

        private void BUpdateTelefon_Click(object sender, EventArgs e)
        {
            if (f.cbTelefons.Items.Count == 0)
            {
                MessageBox.Show("No has modificat res");
            }
            else
            {
                telefon tel = new telefon();
                tel = f.cbTelefons.SelectedItem as telefon;
                String te = f.tbTelefon.Text.ToString();
                r.UpdateTel(tel, te);
                LoadData();
            }

        }

        private void BAfegirTelefon_Click(object sender, EventArgs e)
        {
            con = f.lbContactes.SelectedItem as contacte;
            String te = f.tbTelefon.Text.ToString();
            r.InsertTel(te, con.contacteId);
            LoadData();
        }

        private void BDeleteEmail_Click(object sender, EventArgs e)
        {
            if (f.dgvEmails.Rows.Count == 0)
            {
                MessageBox.Show("No estas eliminant res");
            }
            else
            {
                email em = new email();

                em = f.dgvEmails.CurrentRow.DataBoundItem as email;
                r.DeleteEmail(em);
                LoadData();
            }

        }

        private void BUpdateEmail_Click(object sender, EventArgs e)
        {
            if (f.dgvEmails.Rows.Count == 0)
            {
                MessageBox.Show("No has modificat res");
            }
            else
            {
                email em = new email();
                em = f.dgvEmails.CurrentRow.DataBoundItem as email;
                String email = f.tbEmails.Text.ToString();
                r.UpdateEmail(em, email);
                LoadData();
            }
        }

        private void BAfegirEmail_Click(object sender, EventArgs e)
        {
            con = f.lbContactes.SelectedItem as contacte;
            String email = f.tbEmails.Text.ToString();
            r.InsertEmail(email,con.contacteId);
            LoadData();
        }

        private void CbTelefons_SelectedIndexChanged(object sender, EventArgs e)
        {
                telefon tel = new telefon();
                tel = f.cbTelefons.SelectedItem as telefon;
                f.tbTelefon.Text = tel.telefon1.ToString();
            
        }

        private void DgvEmails_SelectionChanged(object sender, EventArgs e)
        {
            
                email em = new email();
                em = f.dgvEmails.CurrentRow.DataBoundItem as email;
                f.tbEmails.Text = em.email1.ToString();
            
        }

        private void LbContactes_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = f.lbContactes.SelectedItem as contacte;
            f.cbTelefons.DataSource = con.telefons.ToList();
            if (con.telefons.ToList().Count == 0)
            {
                f.cbTelefons.Text = "";
                f.tbTelefon.Text = "";
            }
            else
            {
                f.cbTelefons.DisplayMember = "telefon1";
            }
            f.dgvEmails.DataSource = con.emails.ToList();
            f.dgvEmails.Columns["contacteId"].Visible = false;
            f.dgvEmails.Columns["emailId"].Visible = false;
            f.dgvEmails.Columns["tipus"].Visible = false;
            f.dgvEmails.Columns["contacte"].Visible = false;
            if (con.emails.ToList().Count == 0)
            {
                f.tbEmails.Text = "";
            }
        }

        void LoadContactes()
        {
            f.lbContactes.DataSource = r.GetContactes();           
        }
    }
}
