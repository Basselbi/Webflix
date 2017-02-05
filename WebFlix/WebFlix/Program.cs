using System;
using System.Windows.Forms;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using WebFlix.domain;
namespace WebFlix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            


            



        }
    }
}
