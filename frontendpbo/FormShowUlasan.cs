using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo
{
    public partial class FormShowUlasan : Form
    {
        Contexts.ContextUlasan ulasanContext;
        public FormShowUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();

            ulasanContext.Read();
            dataGridViewsShowUlasan.DataSource = ulasanContext.listUlasan;
        }
    }
}
