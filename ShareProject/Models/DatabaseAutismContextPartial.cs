using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareProject.Models
{
    //partial keyword allow you to define same class in different file
    public partial class DatabaseAutismContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //add scaffold item will not run the program, build only. so it cannot get the connection string from program.cs
            //of course know 
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5APL198\\SQLEXPRESS;Database=Austim;Trusted_Connection=True");
                //rasengan
            }
        }
    }
}
