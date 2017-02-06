using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebFlix.Domain;
using WebFlix.Helpers;

namespace WebFlix
{
    public partial class FormBrowseMyRentals : Form
    {
        public FormBrowseMyRentals()
        {
            InitializeComponent();

            ISession s = NHibernateHelper.GetCurrentSession();
            ITransaction tx = s.BeginTransaction();
            IQuery query = s.CreateQuery("select l from Location l where l.Users.Userid = :userId");
            query.SetParameter("userId", UserSession.Current.Userid);
            IList<Location> locations = query.List<Location>();
            tx.Commit();

            foreach (Location l in locations)
            {
                listBox1.Items.Add(l);
            }
        }
    }
}
