using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFlix
{
    public partial class InscriptionForm : Form
    {
        public InscriptionForm()
        {
            InitializeComponent();
            
        }

        private void InscriptionForm_Load(object sender, EventArgs e)
        {
            dateExpirationBox.Format = DateTimePickerFormat.Custom;
            dateExpirationBox.CustomFormat = "MM yyyy";
            dateExpirationBox.ShowUpDown = true;
            creditCardBox.Items.Add("Master Card");
            creditCardBox.Items.Add("VISA");
            creditCardBox.Items.Add("AMEX");
        }

        private void dateExpirationBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
