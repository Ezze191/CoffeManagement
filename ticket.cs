using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class ticket : Form
    {
        public string data_description {  get; set; }
        public double data_total {  get; set; }
        
        public string data_name { get; set; }

        public string data_apellido { get; set; }


        public ticket()
        {
            InitializeComponent();
        }

        private void ticket_Load(object sender, EventArgs e)
        {
            label1.Text = data_description;
        }
    }
}
