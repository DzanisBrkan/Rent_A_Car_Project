using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Rent_A_CarContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grad>().HasData(new WebAPI.Database.Grad()
            {
                GradId = 100,
                Naziv = "Mostar",
                PostanskiBr = "88000",
                DrzavaId = 1
            });
        }
    }
}
