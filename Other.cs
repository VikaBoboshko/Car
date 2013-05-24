using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace car
{
    public partial class Other : Form
    {
        public Other()
        {
            InitializeComponent();
        }

       // NewCar newCar = new NewCar();
        private void Other_Load(object sender, EventArgs e)
        {
           // newCar.rowProperties.Add("other");            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
