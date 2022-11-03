using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Tietokantaa varten
namespace Harjoitus2
{
    public class Pelitietokanta : DbContext
    {
        public DbSet<Login>? Logins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=.;" +
            "Initial Catalog=Pelitietokanta;" +
            "Integrated Security=true;" + 
            //"User Id = sa; " + "Password = salasana; " 
            "MultipleActiveResultSets=true;";
            // Tässä otetaan yhteys tietokantaan
            optionsBuilder.UseSqlServer(connection);
        }
    }
}