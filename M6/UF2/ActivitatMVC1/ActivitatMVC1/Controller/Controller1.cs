using ActivitatMVC1.Model;
using ActivitatMVC1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivitatMVC1.Controller
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
            LoadCombobox();
            f.radioButton1.Checked = true;            
        }

        void LoadCombobox()
        {
            f.comboBox1.DataSource = r.GetGenres();
            f.comboBox1.DisplayMember = "Name";
        }
        
        void InitListeners()
        {
            f.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            f.radioButton1.CheckedChanged += radioButton_CheckedChanged;
            f.radioButton2.CheckedChanged += radioButton_CheckedChanged;
            f.button1.Click += button1_Click;
        }

        void radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            //f.listBox1.Visible = ((sender as RadioButton).Name == "radioButton1");      // sender objecte on el que sa produit l'event!

            if ((sender as RadioButton).Name == "radioButton1")
            {
                f.listBox1.Visible = true;
                f.listBox2.Visible = false;
            }
            else
            {
                f.listBox1.Visible = false;
                f.listBox2.Visible = true;
            }

            //f.listBox2.Visible = !f.listBox1.Visible;
        }

        void comboBox1_SelectedIndexChanged(Object sender, EventArgs e)
        {            
            if (f.listBox1.Visible)
            {
                f.listBox1.Items.Add(f.comboBox1.Text);
            }
            if (f.listBox2.Visible)
            {
                f.listBox2.Items.Add(f.comboBox1.Text);
            }                       
        }

        void button1_Click(object sender, EventArgs e)
        {
            LoadCombobox();
        }


    }
}
