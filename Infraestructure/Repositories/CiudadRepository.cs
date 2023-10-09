using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        private readonly AnimalsContext _context;

        public CiudadRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }

    } 
    
}