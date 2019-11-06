using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Jquery_Data_Table___CSharpCorner.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}