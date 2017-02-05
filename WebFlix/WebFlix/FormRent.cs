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
//            ISession s = NHibernateHelper.GetCurrentSession();
//            ITransaction tx = s.BeginTransaction();
//            IQuery query = s.GetNamedQuery("FAIRELOCATION");
//            query.SetInt32(0, UserSession.Current.Userid);
//            query.SetInt32(1, movie.Filmid);
//            tx.Commit();

            this.Close();
        }
    }
}
