using BlueCoding.Test.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCoding.Test.Models
{
    public class SeedDB
    {
        public static void SeedDBPlants(DataContext dataContext)
        {
            dataContext.Database.Migrate();

            if (dataContext.Plants.Count() == 0)
            {
                dataContext.Plants.AddRange(new Plant
                {
                    Name = "Girasol ",
                    Description = "Girasol Description "
                },

                new Plant
                {
                    Name = "Amapola ",
                    Description = " Amapola Description"
                },
                new Plant
                {
                    Name = "Tomillo ",
                    Description = "Tomillo Description"
                }
                );
            }
            dataContext.SaveChanges();
        }
    }
}
