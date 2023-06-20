using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using frontendpbo.Helpers;
using frontendpbo.Contexts;
using System.Runtime.InteropServices;
using frontendpbo.Models;
using Npgsql;

namespace frontendpbo
{
    
    public partial class FormEditUlasan : Form
    {


        Contexts.ContextUlasan ulasanContext;
        public FormEditUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
        }

        private void FormEditUlasan_Load(object sender, EventArgs e)
        {
              
        }

        private void FormEditUlasan_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
           
 
        }
    }
}
