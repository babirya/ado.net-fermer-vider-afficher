using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  


namespace DevTechTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        // declaration global pour la classe ado
        ado d = new ado(); 
        
         // this is  for vider button 

            public void vider(Control f )
            {
                foreach (Control ct in f.Controls)
                { 
                    // this for textbox
                    if(ct.GetType()==typeof(TextBox))
                    {
                           ct.Text="";
                    } 

                    // this  for  group box  

                    if(ct.Controls.Count!=0)
                    {
                        vider(ct);
                    }
                   
                }

            }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select *from sta";
            d.cmd.Connection = d.con; 

            d.rd = d.cmd.ExecuteReader(); 
            // other method using datatable 
            d.dt.Load(d.rd);

            dataGridView1.DataSource = d.dt;

            d.rd.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulervous quitter ?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes) 
                d.deconnecter();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("vouler vous vider votre form","comfirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                vider(this); 
            }
        }
        }
    }

