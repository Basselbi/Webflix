using NHibernate;
using System;
using System.Windows.Forms;
using WebFlix.Domain;
using WebFlix.Helpers;

namespace WebFlix
{
    public partial class FormRent : Form
    {
        private Film movie = null;

        public FormRent(Film f)
        {
            InitializeComponent();

            labelTitle.Text = f.ToString();
            richTextBoxDescription.Text = f.Resume;

            movie = f;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            ISession s = NHibernateHelper.GetCurrentSession();
            ITransaction tx = s.BeginTransaction();
            IQuery query = s.CreateSQLQuery("CALL FAIRELOCATION(:pUserId, :pFilmId)");
            query.SetParameter("pUserId", UserSession.Current.Userid);
            query.SetParameter("pFilmId", movie.Filmid);
            query.ExecuteUpdate();
            tx.Commit();

            this.Close();
        }
    }
}
