using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 
using System.Text;
using System.Collections.Generic;
using NHibernate ;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using WebFlix.domain;



namespace WebflixTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_generate_schema()

        {

            var cfg = new Configuration();

            cfg.Configure();

            cfg.AddAssembly(typeof(Users).Assembly);



          //  new SchemaExport(cfg).Execute(false, true, false, false);

        }
    }
}
