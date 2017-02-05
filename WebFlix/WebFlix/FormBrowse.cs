using NHibernate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using WebFlix.Domain;
using WebFlix.Helpers;

namespace WebFlix
{
    public partial class FormBrowse : Form
    {
        private IList<Film> movies = null;

        public FormBrowse()
        {
            InitializeComponent();

            // Get movies from db
            ISession s = NHibernateHelper.GetCurrentSession();
            ITransaction tx = s.BeginTransaction();
            IQuery query = s.CreateQuery("select f from Film f where f.Qtydisponible > 0 order by f.Annesortie DESC, f.Titre");
            movies = query.List<Film>();
            tx.Commit();

            foreach (Film f in movies)
            {
                listBox.Items.Add(f);
            }
        }

        // Sexy gradient
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Gray,
                                                                       Color.Black,
                                                                       45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
            if (listBox.SelectedItem != null)
            {
                new FormRent((Film)listBox.SelectedItem).Show();
            }
        }
    }
}
