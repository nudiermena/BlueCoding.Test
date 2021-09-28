using BlueCoding.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCoding.Test.Repository.Interfaces
{
    public interface IPlantRepository
    {
        public Task<IEnumerable<Plant>> Get();
    }
}
