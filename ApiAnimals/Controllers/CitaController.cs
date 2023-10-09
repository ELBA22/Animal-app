using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;

namespace ApiAnimals.Controllers;
public class CitaController : BaseControllerApi
{
        private readonly IUnitOfWork _UnitOfWork;

        public CitaController (IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        
}
