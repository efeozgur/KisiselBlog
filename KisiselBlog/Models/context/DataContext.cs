using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KisiselBlog.Models.modeller;

namespace KisiselBlog.Models.context
{
    public class DataContext:DbContext
    {
        public DbSet<Yazi> Yazilar { get; set; }

    }
}