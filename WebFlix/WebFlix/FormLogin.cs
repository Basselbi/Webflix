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

            // Pour accélérer le développement, valeurs par défaut au login.
            textBoxEmail.Text = "RobertCFlores21@gmail.com";
            textBoxPassword.Text = "eishie3meiH";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ISession s = NHibernateHelper.GetCurrentSession();
            ITransaction tx = s.BeginTransaction();
            IQuery query = s.CreateQuery("select u from Users u where u.Courriel = :courriel and u.Motpasse = :motpasse");
            query.SetString("courriel", textBoxEmail.Text);
            query.SetString("motpasse", textBoxPassword.Text);
            IList<Users> result = query.List<Users>();
            tx.Commit();

            if (result.Count > 0)
            {
                // Enregistre l'utilisateur courant dans un singleton
                UserSession.Current = result.First<Users>();

                // Navigue vers la page de 'browsing'
                var th = new Thread(() => Application.Run(new FormBrowse()));
                th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
                th.Start();

                this.Close();
            }
            else
            {
                MessageBox.Show("Courriel ou mot de passe invalide");
            }
        }
    }
}
