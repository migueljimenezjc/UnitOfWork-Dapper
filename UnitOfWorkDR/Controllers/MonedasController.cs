using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntitiesER;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkDR.API.Authorization;
using UnitOfWorkDR.API.Controllers;
using UnitOfWorkDR.API.UnitOfWork;

namespace UnitOfWorkDR.Controllers
{
    [Produces("application/json")]
    [Route("api/Monedas")]
    public class MonedasController : BaseController
    {
        public MonedasController(IUnitOfWork unitOfWork, IApplicationContext context) : base(unitOfWork, context)
        {

        }

        public async Task<IEnumerable<REM_MONEDA>> Get() => await UnitOfWork.MonedaRepository.GetAllAsync(); 
    }
}