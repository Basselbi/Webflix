using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFlix
{
    public partial class FormBrowse : Form
    {
        public FormBrowse()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new FormLogin()));
            th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
            th.Start();

            this.Close();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            new FormRent().Show();
        }
    }
}
