using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_A_Car.WebAPI.Database
{
    public class Data
    {
        public static void Seed(Rent_A_CarContext context)
        {
            context.Database.Migrate();
        }
    }
}
