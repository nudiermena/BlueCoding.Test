using BlueCoding.Test.Context;
using BlueCoding.Test.Models;
using BlueCoding.Test.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCoding.Test.Repository
{
    public class PlantRepository : IPlantRepository
    {
        private readonly DataContext _dataContext;
        public PlantRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Plant>> Get()
        {
            return await this._dataContext.Plants.ToListAsync();
        }
    }
}
