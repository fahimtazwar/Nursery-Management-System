using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Nursery.Models
{
    public class myDB : DbContext
    {
        public DbSet<userForReg> userRegi { get; set; }
        public DbSet<supplier> suppp { get; set; }
        public DbSet<employee> emppp { get; set; }
        public DbSet<plant> plantT { get; set; }


    }
}