﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Cfg;
using WebFlix.domain;

namespace WebFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                
            }
        }

        private void InscriptionBOX_Click(object sender, EventArgs e)
        {
            InscriptionForm  formInscriptionForm= new InscriptionForm();
            formInscriptionForm.Show();
        }
    }
}
