using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WebFlix.Helpers;
using WebFlix.Domain;
using NHibernate.Cfg;

namespace WebFlix
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ISession s = NHibernateHelper.GetCurrentSession();
            ITransaction tx = s.BeginTransaction();
            IQuery query = s.CreateQuery("select u from Users u where u.Courriel = :courriel");
            query.SetString("courriel", "RobertCFlores21@gmail.com");

            IList<Users> result = query.List<Users>();
            foreach (Users u in result)
            {
                Console.Out.WriteLine(u.Nom);
            }
            tx.Commit();
        }
    }
}
